<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2023/12/30 00:35:47">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="5">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="9">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="32" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 3 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 -3 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 3 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="168 0 -1" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="216 0 -1" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="679">
                    <Brush id="0" owner="0" type="0" pos="2 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 2" />
                            <Vertex pos="6 4 -2" />
                            <Vertex pos="6 -4 2" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="-6 4 2" />
                            <Vertex pos="-6 4 -2" />
                            <Vertex pos="-6 -4 2" />
                            <Vertex pos="-6 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="6 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="1" type="999" pos="20 3 0" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 1 1" />
                            <Vertex pos="-6 1 -1" />
                            <Vertex pos="-6 -1 1" />
                            <Vertex pos="-6 -1 -1" />
                            <Vertex pos="-12 1 1" />
                            <Vertex pos="-12 1 -1" />
                            <Vertex pos="-12 -1 1" />
                            <Vertex pos="-12 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 6" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="36 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 -2" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="34 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 34 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="41 0 4.76837e-007" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 0 0 0 1 4.76837e-007 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 3" />
                            <Vertex pos="1 4 -3" />
                            <Vertex pos="1 -4 3" />
                            <Vertex pos="1 -4 -3" />
                            <Vertex pos="-1 4 1" />
                            <Vertex pos="-1 4 -3" />
                            <Vertex pos="-1 -4 1" />
                            <Vertex pos="-1 -4 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -1.41421" album="" material="bm_friction_sand" texgens="1 0 0 10496 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="45 0 0" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 3" />
                            <Vertex pos="3 4 -3" />
                            <Vertex pos="3 -4 3" />
                            <Vertex pos="3 -4 -3" />
                            <Vertex pos="-3 4 3" />
                            <Vertex pos="-3 4 -3" />
                            <Vertex pos="-3 -4 3" />
                            <Vertex pos="-3 -4 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile07_C" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="49 1.19209e-007 1" rot="1 0 0 0" scale="" transform="1 0 0 49 0 1 0 1.19209e-007 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 4" />
                            <Vertex pos="1 4 -4" />
                            <Vertex pos="1 -4 4" />
                            <Vertex pos="1 -4 -4" />
                            <Vertex pos="-1 4 1.99999" />
                            <Vertex pos="-1 4 -4" />
                            <Vertex pos="-1 -4 1.99999" />
                            <Vertex pos="-1 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707108 0 0.707105 -2.12131" album="" material="bm_friction_sand" texgens="1 0 0 12544 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="53 0 1" rot="1 0 0 0" scale="" transform="1 0 0 53 0 1 0 0 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 4" />
                            <Vertex pos="3 4 -4" />
                            <Vertex pos="3 -4 4" />
                            <Vertex pos="3 -4 -4" />
                            <Vertex pos="-3 4 4" />
                            <Vertex pos="-3 4 -4" />
                            <Vertex pos="-3 -4 4" />
                            <Vertex pos="-3 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile07_C" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="54 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="58 0 4" rot="1 0 0 0" scale="" transform="1 0 0 58 0 1 0 0 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 1" />
                            <Vertex pos="2 4 -1" />
                            <Vertex pos="2 -4 1" />
                            <Vertex pos="2 -4 -1" />
                            <Vertex pos="-2 4 1" />
                            <Vertex pos="-2 4 -1" />
                            <Vertex pos="-2 -4 1" />
                            <Vertex pos="-2 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="86 0 0" rot="1 0 0 0" scale="" transform="1 0 0 86 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 1" />
                            <Vertex pos="2 4 -1" />
                            <Vertex pos="2 -4 1" />
                            <Vertex pos="2 -4 -1" />
                            <Vertex pos="-2 4 1" />
                            <Vertex pos="-2 4 -1" />
                            <Vertex pos="-2 -4 1" />
                            <Vertex pos="-2 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="90 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 90 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="92 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 92 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 -2" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="116 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 116 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="20 4 2" />
                            <Vertex pos="20 4 -2" />
                            <Vertex pos="20 -4 2" />
                            <Vertex pos="20 -4 -2" />
                            <Vertex pos="-20 4 2" />
                            <Vertex pos="-20 4 -2" />
                            <Vertex pos="-20 -4 2" />
                            <Vertex pos="-20 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -20" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -20" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -1792 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 2048 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_friction_ice" texgens="1 0 0 29696 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -1792 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="112 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 112 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 17" />
                            <Vertex pos="4 4 -17" />
                            <Vertex pos="4 -4 17" />
                            <Vertex pos="4 -4 -17" />
                            <Vertex pos="-4 4 17" />
                            <Vertex pos="-4 4 -17" />
                            <Vertex pos="-4 -4 17" />
                            <Vertex pos="-4 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 2048 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="134 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 134 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="138 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 138 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 -4 2" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="158 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 158 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 2" />
                            <Vertex pos="6 4 -2" />
                            <Vertex pos="6 -4 2" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="162 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 162 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -1024 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 1280 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 2560 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="5" type="999" pos="168 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 168 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 -2" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile01_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="226 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 226 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 2" />
                            <Vertex pos="6 4 -2" />
                            <Vertex pos="6 -4 2" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="-6 4 2" />
                            <Vertex pos="-6 4 -2" />
                            <Vertex pos="-6 -4 2" />
                            <Vertex pos="-6 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="222 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="15 4 3" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 4 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -2" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -2" />
                            <Vertex pos="-1 2 2" />
                            <Vertex pos="-1 2 -2" />
                            <Vertex pos="-1 -2 2" />
                            <Vertex pos="-1 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="21 -3 3" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -3 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 2" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 -2" />
                            <Vertex pos="-1 3 2" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="27 1 3" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 1 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="27 -4 3" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 -4 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -2" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -2" />
                            <Vertex pos="-1 2 2" />
                            <Vertex pos="-1 2 -2" />
                            <Vertex pos="-1 -2 2" />
                            <Vertex pos="-1 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-6 -6 -17" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -6 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 18" />
                            <Vertex pos="6 2 -20" />
                            <Vertex pos="2 -2 20" />
                            <Vertex pos="2 -2 -20" />
                            <Vertex pos="-6 2 18" />
                            <Vertex pos="-6 2 -20" />
                            <Vertex pos="-6 -2 20" />
                            <Vertex pos="-6 -2 -20" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -16.9941" album="" material="bm_friction_grass" texgens="1 0 0 -1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-6 6 -17" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 6 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 20" />
                            <Vertex pos="2 2 -20" />
                            <Vertex pos="6 -2 18" />
                            <Vertex pos="6 -2 -20" />
                            <Vertex pos="-6 2 20" />
                            <Vertex pos="-6 2 -20" />
                            <Vertex pos="-6 -2 18" />
                            <Vertex pos="-6 -2 -20" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.82843" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -16.9941" album="" material="bm_friction_grass" texgens="1 0 0 -1536 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-16 6 -15" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 6 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 18" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 21" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 18" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 21" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.6 0.8 -15.6" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-16 -6 -15" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -6 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 21" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 18" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 21" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 18" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -15.6" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="234 -6 -17" rot="1 0 0 0" scale="" transform="1 0 0 234 0 1 0 -6 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 18" />
                            <Vertex pos="6 2 -20" />
                            <Vertex pos="6 -2 20" />
                            <Vertex pos="6 -2 -20" />
                            <Vertex pos="-6.00002 2 18" />
                            <Vertex pos="-6.00002 2 -20" />
                            <Vertex pos="-2.00002 -2 20" />
                            <Vertex pos="-2.00002 -2 -20" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.82844" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -16.9941" album="" material="bm_friction_grass" texgens="1 0 0 59904 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="234 6 -17" rot="1 0 0 0" scale="" transform="1 0 0 234 0 1 0 6 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 20" />
                            <Vertex pos="6 2 -20" />
                            <Vertex pos="6 -2 18" />
                            <Vertex pos="6 -2 -20" />
                            <Vertex pos="-1.99998 2 20" />
                            <Vertex pos="-1.99998 2 -20" />
                            <Vertex pos="-5.99998 -2 18" />
                            <Vertex pos="-5.99998 -2 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.82841" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -16.9941" album="" material="bm_friction_grass" texgens="1 0 0 59904 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="244 6 -15" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 6 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 18" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 21" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 18" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 21" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.6 0.8 -15.6" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="244 -6 -15" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 -6 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 21" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 18" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 21" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 18" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -15.6" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-8 0 -18" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 -18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 19" />
                            <Vertex pos="4 4 -19" />
                            <Vertex pos="4 -4 19" />
                            <Vertex pos="4 -4 -19" />
                            <Vertex pos="-4 4 19" />
                            <Vertex pos="-4 4 -19" />
                            <Vertex pos="-4 -4 19" />
                            <Vertex pos="-4 -4 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile07_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="38 0 -55" rot="1 0 0 0" scale="" transform="1 0 0 38 0 1 0 0 0 0 1 -55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="76 32 18" />
                            <Vertex pos="76 32 -18" />
                            <Vertex pos="76 -32 18" />
                            <Vertex pos="76 -32 -18" />
                            <Vertex pos="-44 32 18" />
                            <Vertex pos="-44 32 -18" />
                            <Vertex pos="-44 -32 18" />
                            <Vertex pos="-44 -32 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -76" album="" material="bm_grid_blank4" texgens="0 1 0 4352 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -44" album="" material="bm_grid_blank4" texgens="0 -1 0 -4096 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 -8448 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -32" album="" material="bm_grid_blank4" texgens="1 0 0 8704 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_grid_blank_water" texgens="1 0 0 -9472 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -8448 0 -1 0 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="190 0 -55" rot="1 0 0 0" scale="" transform="1 0 0 190 0 1 0 0 0 0 1 -55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="44 32 18" />
                            <Vertex pos="44 32 -18" />
                            <Vertex pos="44 -32 18" />
                            <Vertex pos="44 -32 -18" />
                            <Vertex pos="-76 32 18" />
                            <Vertex pos="-76 32 -18" />
                            <Vertex pos="-76 -32 18" />
                            <Vertex pos="-76 -32 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -44" album="" material="bm_grid_blank4" texgens="0 1 0 4352 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -76" album="" material="bm_grid_blank4" texgens="0 -1 0 -4096 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 -8448 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -32" album="" material="bm_grid_blank4" texgens="1 0 0 8704 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_grid_blank_water" texgens="1 0 0 -9472 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -8448 0 -1 0 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="0 0 -26" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 11" />
                            <Vertex pos="4 4 -11" />
                            <Vertex pos="4 -4 11" />
                            <Vertex pos="4 -4 -11" />
                            <Vertex pos="-4 4 11" />
                            <Vertex pos="-4 4 -11" />
                            <Vertex pos="-4 -4 11" />
                            <Vertex pos="-4 -4 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_friction_grass" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="228 0 -26" rot="1 0 0 0" scale="" transform="1 0 0 228 0 1 0 0 0 0 1 -26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 11" />
                            <Vertex pos="4 4 -11" />
                            <Vertex pos="4 -4 11" />
                            <Vertex pos="4 -4 -11" />
                            <Vertex pos="-4 4 11" />
                            <Vertex pos="-4 4 -11" />
                            <Vertex pos="-4 -4 11" />
                            <Vertex pos="-4 -4 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_friction_grass" texgens="1 0 0 58368 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="236 0 -18" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 0 0 0 1 -18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 19" />
                            <Vertex pos="4 4 -19" />
                            <Vertex pos="4 -4 19" />
                            <Vertex pos="4 -4 -19" />
                            <Vertex pos="-4 4 19" />
                            <Vertex pos="-4 4 -19" />
                            <Vertex pos="-4 -4 19" />
                            <Vertex pos="-4 -4 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile07_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="381" owner="0" type="0" pos="3 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="382" owner="0" type="0" pos="3 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="383" owner="0" type="0" pos="36 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="384" owner="0" type="0" pos="36 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="385" owner="0" type="0" pos="45 -4.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 -4.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="386" owner="0" type="0" pos="45 4.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 4.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="387" owner="0" type="0" pos="55 -4.25 4.75" rot="1 0 0 0" scale="" transform="1 0 0 55 0 1 0 -4.25 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="388" owner="0" type="0" pos="55 4.25 4.75" rot="1 0 0 0" scale="" transform="1 0 0 55 0 1 0 4.25 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="389" owner="0" type="0" pos="49 -4.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 49 0 1 0 -4.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="390" owner="0" type="0" pos="49 4.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 49 0 1 0 4.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="391" owner="0" type="0" pos="41 -4.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 -4.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="392" owner="0" type="0" pos="41 4.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 4.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="393" owner="0" type="0" pos="112 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 112 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="28 0.25 0.25" />
                            <Vertex pos="28 0.25 -0.25" />
                            <Vertex pos="28 -0.25 0.25" />
                            <Vertex pos="28 -0.25 -0.25" />
                            <Vertex pos="-28 0.25 0.25" />
                            <Vertex pos="-28 0.25 -0.25" />
                            <Vertex pos="-28 -0.25 0.25" />
                            <Vertex pos="-28 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -28" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -28" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5120 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5248 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5120 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="394" owner="0" type="0" pos="112 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 112 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="28 0.25 0.25" />
                            <Vertex pos="28 0.25 -0.25" />
                            <Vertex pos="28 -0.25 0.25" />
                            <Vertex pos="28 -0.25 -0.25" />
                            <Vertex pos="-28 0.25 0.25" />
                            <Vertex pos="-28 0.25 -0.25" />
                            <Vertex pos="-28 -0.25 0.25" />
                            <Vertex pos="-28 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -28" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -28" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5120 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5248 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5120 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="395" owner="0" type="0" pos="60.25 -1 4.75" rot="1 0 0 0" scale="" transform="1 0 0 60.25 0 1 0 -1 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.25" />
                            <Vertex pos="0.25 0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 0.25" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="396" owner="0" type="0" pos="60.25 3.5 4.75" rot="1 0 0 0" scale="" transform="1 0 0 60.25 0 1 0 3.5 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="397" owner="0" type="0" pos="83.75 1 0.75" rot="1 0 0 0" scale="" transform="1 0 0 83.75 0 1 0 1 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.25" />
                            <Vertex pos="0.25 0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 0.25" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="398" owner="0" type="0" pos="83.75 -3.5 0.75" rot="1 0 0 0" scale="" transform="1 0 0 83.75 0 1 0 -3.5 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="399" owner="1" type="999" pos="20 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 0.25 0.25" />
                            <Vertex pos="12 0.25 -0.25" />
                            <Vertex pos="12 -0.25 0.25" />
                            <Vertex pos="12 -0.25 -0.25" />
                            <Vertex pos="-12 0.25 0.25" />
                            <Vertex pos="-12 0.25 -0.25" />
                            <Vertex pos="-12 -0.25 0.25" />
                            <Vertex pos="-12 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="Blasted" material="bm_edge_mp2" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="Blasted" material="bm_edge_mp2" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_mp2" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_mp2" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_mp2" texgens="1 0 0 640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_mp2" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="400" owner="1" type="999" pos="20 1.75 0.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 1.75 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 0.25 0.25" />
                            <Vertex pos="12 0.25 -0.25" />
                            <Vertex pos="12 -0.25 0.25" />
                            <Vertex pos="12 -0.25 -0.25" />
                            <Vertex pos="-12 0.25 0.25" />
                            <Vertex pos="-12 0.25 -0.25" />
                            <Vertex pos="-12 -0.25 0.25" />
                            <Vertex pos="-12 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="Blasted" material="bm_edge_mp2" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="Blasted" material="bm_edge_mp2" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_mp2" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_mp2" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_mp2" texgens="1 0 0 640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_mp2" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="401" owner="0" type="0" pos="158 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 158 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="402" owner="0" type="0" pos="158 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 158 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="403" owner="0" type="0" pos="140.125 0 0.75" rot="1 0 0 0" scale="" transform="1 0 0 140.125 0 1 0 0 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4.5 0.25" />
                            <Vertex pos="0.125 4.5 -0.25" />
                            <Vertex pos="0.125 -4.5 0.25" />
                            <Vertex pos="0.125 -4.5 -0.25" />
                            <Vertex pos="-0.125 4.5 0.25" />
                            <Vertex pos="-0.125 4.5 -0.25" />
                            <Vertex pos="-0.125 -4.5 0.25" />
                            <Vertex pos="-0.125 -4.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_trim" texgens="-1 0 0 2016 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_trim" texgens="1 0 0 -1888 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -1888 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 2016 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="404" owner="0" type="0" pos="155.875 0 0.75" rot="1 0 0 0" scale="" transform="1 0 0 155.875 0 1 0 0 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4.5 0.25" />
                            <Vertex pos="0.125 4.5 -0.25" />
                            <Vertex pos="0.125 -4.5 0.25" />
                            <Vertex pos="0.125 -4.5 -0.25" />
                            <Vertex pos="-0.125 4.5 0.25" />
                            <Vertex pos="-0.125 4.5 -0.25" />
                            <Vertex pos="-0.125 -4.5 0.25" />
                            <Vertex pos="-0.125 -4.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_trim" texgens="-1 0 0 1952 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_trim" texgens="1 0 0 -1824 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -1824 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 1952 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="405" owner="0" type="0" pos="225 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 225 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="406" owner="0" type="0" pos="225 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 225 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="407" owner="5" type="999" pos="168 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 168 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_mp1" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_mp1" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_mp1" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_mp1" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_mp1" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_mp1" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="408" owner="5" type="999" pos="168 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 168 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_mp1" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_mp1" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_mp1" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_mp1" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_mp1" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_mp1" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="409" owner="1" type="999" pos="28 3 0" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-12 1 1" />
                            <Vertex pos="-12 1 -1" />
                            <Vertex pos="-12 -1 1" />
                            <Vertex pos="-12 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="410" owner="1" type="999" pos="34 3 0" rot="1 0 0 0" scale="" transform="1 0 0 34 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-12 1 1" />
                            <Vertex pos="-12 1 -1" />
                            <Vertex pos="-12 -1 1" />
                            <Vertex pos="-12 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="411" owner="1" type="999" pos="40 3 0" rot="1 0 0 0" scale="" transform="1 0 0 40 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-12 1 1" />
                            <Vertex pos="-12 1 -1" />
                            <Vertex pos="-12 -1 1" />
                            <Vertex pos="-12 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="412" owner="1" type="999" pos="36 3 0" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-10 1 1" />
                            <Vertex pos="-10 1 -1" />
                            <Vertex pos="-10 -1 1" />
                            <Vertex pos="-10 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile01_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="413" owner="1" type="999" pos="30 3 0" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-10 1 1" />
                            <Vertex pos="-10 1 -1" />
                            <Vertex pos="-10 -1 1" />
                            <Vertex pos="-10 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile01_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="414" owner="1" type="999" pos="24 3 0" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-10 1 1" />
                            <Vertex pos="-10 1 -1" />
                            <Vertex pos="-10 -1 1" />
                            <Vertex pos="-10 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile01_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="416" owner="0" type="0" pos="150.824 -0.25955 1.25" rot="0 0 1.00001 0.17453" scale="" transform="0.984808 0.173648 0 150.824 -0.173648 0.984808 0 -0.25955 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1.75 -0.125" />
                            <Vertex pos="6 1.75 -0.25" />
                            <Vertex pos="6 -0.25 -0.125" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-12 1.75 -0.125" />
                            <Vertex pos="-12 1.75 -0.25" />
                            <Vertex pos="-12 -0.25 -0.125" />
                            <Vertex pos="-12 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_wood" texgens="0 1 0 6639.28 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="Blasted" material="bm_wood" texgens="0 -1 0 -6639.28 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.75" album="Blasted" material="bm_wood" texgens="-1 0 0 -38035.9 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 38035.9 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.125" album="Blasted" material="bm_wood" texgens="1 0 0 38035.9 0 -1 0 -6639.28 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -38035.9 0 -1 0 -6639.28 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="418" owner="0" type="0" pos="135.232 -3.22689 1.15076" rot="0.0086735 0.110209 -0.993884 0.158039" scale="" transform="0.987538 -0.156411 -0.0174524 135.232 0.156434 0.987688 0 -3.22689 0.0172375 -0.00273016 0.999848 1.15076 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15 1.75 -0.125" />
                            <Vertex pos="15 1.75 -0.25" />
                            <Vertex pos="15 -0.25 -0.125" />
                            <Vertex pos="15 -0.25 -0.25" />
                            <Vertex pos="4 1.75 -0.125" />
                            <Vertex pos="4 1.75 -0.25" />
                            <Vertex pos="4 -0.25 -0.125" />
                            <Vertex pos="4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -15" album="Blasted" material="bm_wood" texgens="0 1 0 -6231.55 0 0 -1 309.641 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="Blasted" material="bm_wood" texgens="0 -1 0 6231.55 0 0 -1 309.641 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.75" album="Blasted" material="bm_wood" texgens="-1 0 0 -34063.8 0 0 -1 309.641 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 34063.8 0 0 -1 309.641 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.125" album="Blasted" material="bm_wood" texgens="1 0 0 34063.8 0 -1 0 6231.55 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -34063.8 0 -1 0 6231.55 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="419" owner="0" type="0" pos="175.5 4.25 1.25" rot="1 0 0 0" scale="" transform="1 0 0 175.5 0 1 0 4.25 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.75 0 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="5.75 -8.5 0.25" />
                            <Vertex pos="6 -8.75 -0.25" />
                            <Vertex pos="4.75 0 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.75 -8.5 0.25" />
                            <Vertex pos="4.5 -8.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0 0.447214 -5.25476" album="Blasted" material="bm_stripe_caution1" texgens="0 1 -1 -32 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0 0.447214 4.13673" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 -1 -1248 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.894427 0.447214 -0.111803" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1 832 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.894427 0.447214 -7.71443" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1 -512 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="1 1 0 480 0 -1 0 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="-1 1 0 1920 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="420" owner="0" type="0" pos="182 4.25 1.25" rot="1 0 0 0" scale="" transform="1 0 0 182 0 1 0 4.25 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.75 0 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="5.75 -5 0.25" />
                            <Vertex pos="6 -5.25 -0.25" />
                            <Vertex pos="4.75 0 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.75 -5 0.25" />
                            <Vertex pos="4.5 -5.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0 0.447214 -5.25476" album="Blasted" material="bm_stripe_caution1" texgens="0 1 -1 -32 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0 0.447214 4.13673" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 -1 -1248 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.894427 0.447214 -0.111803" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1 832 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.894427 0.447214 -4.58394" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1 -576 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="1 1 0 480 0 -1 0 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="-1 1 0 1408 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="421" owner="0" type="0" pos="195 3 3" rot="1 0 0 0" scale="" transform="1 0 0 195 0 1 0 3 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 2" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 3 2" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="422" owner="0" type="0" pos="195 -1 3" rot="1 0 0 0" scale="" transform="1 0 0 195 0 1 0 -1 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -5 2" />
                            <Vertex pos="1 -5 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -5 2" />
                            <Vertex pos="-1 -5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="423" owner="0" type="0" pos="189.25 1.75 1.25" rot="1 0 0 0" scale="" transform="1 0 0 189.25 0 1 0 1.75 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -1.75 0.25" />
                            <Vertex pos="6 -1.75 -0.25" />
                            <Vertex pos="5.5 0.25 0.25" />
                            <Vertex pos="5.5 0.25 -0.25" />
                            <Vertex pos="5.5 -1.75 0.25" />
                            <Vertex pos="5.5 -1.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam" texgens="0 1 0 128 0 0 -1 128 90 0.0625 0.0625" texRot="90" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 5.5" album="Blasted" material="bm_beam" texgens="0 -1 0 128 0 0 -1 128 90 0.0625 0.0625" texRot="90" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 -2816 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 3072 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="424" owner="0" type="0" pos="205 -3 3" rot="1 0 0 0" scale="" transform="1 0 0 205 0 1 0 -3 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="425" owner="0" type="0" pos="205 3 3" rot="1 0 0 0" scale="" transform="1 0 0 205 0 1 0 3 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 2" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 -2" />
                            <Vertex pos="-1 3 2" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="426" owner="0" type="0" pos="199.25 -0.25 1.25" rot="1 0 0 0" scale="" transform="1 0 0 199.25 0 1 0 -0.25 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -1.75 0.25" />
                            <Vertex pos="6 -1.75 -0.25" />
                            <Vertex pos="5.5 0.25 0.25" />
                            <Vertex pos="5.5 0.25 -0.25" />
                            <Vertex pos="5.5 -1.75 0.25" />
                            <Vertex pos="5.5 -1.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam" texgens="0 1 0 128 0 0 -1 128 90 0.0625 0.0625" texRot="90" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 5.5" album="Blasted" material="bm_beam" texgens="0 -1 0 128 0 0 -1 128 90 0.0625 0.0625" texRot="90" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 -2816 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 3072 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="427" owner="0" type="0" pos="118.25 1 1.25" rot="1 0 0 0" scale="" transform="1 0 0 118.25 0 1 0 1 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.5 0.75" />
                            <Vertex pos="0.75 0.5 0.25" />
                            <Vertex pos="0.75 -2.5 0.75" />
                            <Vertex pos="0.75 -2.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 -0.75" />
                            <Vertex pos="-0.25 -3.5 -0.25" />
                            <Vertex pos="-0.25 -3.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.2981" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0" album="Blasted" material="bm_friction_ice" texgens="1 0 0 30272 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.353553" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="428" owner="0" type="0" pos="119.25 1 2.25" rot="1 0 0 0" scale="" transform="1 0 0 119.25 0 1 0 1 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 1.5 -1.25" />
                            <Vertex pos="0.75 1.5 -1.75" />
                            <Vertex pos="0.75 -3.5 -1.25" />
                            <Vertex pos="0.75 -3.5 -1.75" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 -0.75" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.94454" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 0.353553" album="Blasted" material="bm_friction_ice" texgens="1 0 0 30528 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.707107" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="429" owner="0" type="0" pos="118.75 2 1.75" rot="1 0 0 0" scale="" transform="1 0 0 118.75 0 1 0 2 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.5 -0.75" />
                            <Vertex pos="1.25 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.75 0.5 -0.75" />
                            <Vertex pos="-0.75 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 0.176777" album="Blasted" material="bm_friction_ice" texgens="1 0 0 30400 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="430" owner="0" type="0" pos="118.25 0 1.75" rot="1 0 0 0" scale="" transform="1 0 0 118.25 0 1 0 0 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -1.5 0.25" />
                            <Vertex pos="0.75 -1.5 -0.25" />
                            <Vertex pos="1.75 -2.5 -0.75" />
                            <Vertex pos="1.75 -2.5 -1.25" />
                            <Vertex pos="0.75 -1.5 0.25" />
                            <Vertex pos="0.75 -1.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 -0.75" />
                            <Vertex pos="-0.25 -2.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 0.53033" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 1.59099" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -1.23744" album="Blasted" material="bm_friction_ice" texgens="1 0 0 30272 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="431" owner="0" type="0" pos="125.25 2 1.25" rot="1 0 0 0" scale="" transform="1 0 0 125.25 0 1 0 2 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.5 0.75" />
                            <Vertex pos="0.75 0.5 0.25" />
                            <Vertex pos="0.75 -1.5 0.75" />
                            <Vertex pos="0.75 -1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 -0.75" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32064 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.353553" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="432" owner="0" type="0" pos="126.25 2 2.25" rot="1 0 0 0" scale="" transform="1 0 0 126.25 0 1 0 2 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 1.5 -1.25" />
                            <Vertex pos="0.75 1.5 -1.75" />
                            <Vertex pos="0.75 -2.5 -1.25" />
                            <Vertex pos="0.75 -2.5 -1.75" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 -0.75" />
                            <Vertex pos="-0.25 -1.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.23744" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 0.353553" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32320 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.707107" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="433" owner="0" type="0" pos="125.75 3 1.75" rot="1 0 0 0" scale="" transform="1 0 0 125.75 0 1 0 3 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.5 -0.75" />
                            <Vertex pos="1.25 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.75 0.5 -0.75" />
                            <Vertex pos="-0.75 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 0.176777" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32192 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="434" owner="0" type="0" pos="125.25 1 1.75" rot="1 0 0 0" scale="" transform="1 0 0 125.25 0 1 0 1 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -0.5 0.25" />
                            <Vertex pos="0.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -1.5 -0.75" />
                            <Vertex pos="1.75 -1.5 -1.25" />
                            <Vertex pos="0.75 -0.5 0.25" />
                            <Vertex pos="0.75 -0.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 -0.75" />
                            <Vertex pos="-0.25 -1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 0.883883" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.53033" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32064 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="435" owner="0" type="0" pos="128.75 -1 1.25" rot="1 0 0 0" scale="" transform="1 0 0 128.75 0 1 0 -1 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.5 0.75" />
                            <Vertex pos="0.75 0.5 0.25" />
                            <Vertex pos="0.75 -1.5 0.75" />
                            <Vertex pos="0.75 -1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 -0.75" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.353553" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="436" owner="0" type="0" pos="129.75 -1 2.25" rot="1 0 0 0" scale="" transform="1 0 0 129.75 0 1 0 -1 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 1.5 -1.25" />
                            <Vertex pos="0.75 1.5 -1.75" />
                            <Vertex pos="0.75 -2.5 -1.25" />
                            <Vertex pos="0.75 -2.5 -1.75" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 -0.75" />
                            <Vertex pos="-0.25 -1.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.23744" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 0.353553" album="Blasted" material="bm_friction_ice" texgens="1 0 0 33216 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.707107" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="437" owner="0" type="0" pos="129.25 0 1.75" rot="1 0 0 0" scale="" transform="1 0 0 129.25 0 1 0 0 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.5 -0.75" />
                            <Vertex pos="1.25 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.75 0.5 -0.75" />
                            <Vertex pos="-0.75 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 0.176777" album="Blasted" material="bm_friction_ice" texgens="1 0 0 33088 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="438" owner="0" type="0" pos="128.75 -2 1.75" rot="1 0 0 0" scale="" transform="1 0 0 128.75 0 1 0 -2 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -0.5 0.25" />
                            <Vertex pos="0.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -1.5 -0.75" />
                            <Vertex pos="1.75 -1.5 -1.25" />
                            <Vertex pos="0.75 -0.5 0.25" />
                            <Vertex pos="0.75 -0.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 -0.75" />
                            <Vertex pos="-0.25 -1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 0.883883" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.53033" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32960 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="439" owner="8" type="4" pos="166 0 3" rot="1 0 0 0" scale="" transform="1 0 0 166 0 1 0 0 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 -1.5" />
                            <Vertex pos="6 4 -2" />
                            <Vertex pos="6 -4 -1.5" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="-2 4 -1.5" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 -1.5" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="" material="bm_tile07_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="440" owner="0" type="0" pos="9 3.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 3.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 224 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -2304 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="442" owner="0" type="0" pos="9 3.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 3.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -160 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 2304 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="445" owner="0" type="0" pos="15 -0.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -0.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -3840 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 3840 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 3840 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -3840 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="446" owner="0" type="0" pos="15 -0.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -0.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 3840 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -3840 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="447" owner="0" type="0" pos="21 1.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 1.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="448" owner="0" type="0" pos="21 1.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 1.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="449" owner="0" type="0" pos="21 -2.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -2.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="450" owner="0" type="0" pos="21 -2.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -2.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="451" owner="0" type="0" pos="189 3.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 189 0 1 0 3.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 224 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="452" owner="0" type="0" pos="189 3.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 189 0 1 0 3.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -160 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="453" owner="0" type="0" pos="189 -0.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 189 0 1 0 -0.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="454" owner="0" type="0" pos="189 -0.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 189 0 1 0 -0.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="455" owner="0" type="0" pos="199 1.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 199 0 1 0 1.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 224 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="456" owner="0" type="0" pos="199 1.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 199 0 1 0 1.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -160 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="457" owner="0" type="0" pos="199 -2.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 199 0 1 0 -2.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="458" owner="0" type="0" pos="199 -2.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 199 0 1 0 -2.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="460" owner="0" type="0" pos="6 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 13" />
                            <Vertex pos="-4 -4 13" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.124035 0 0.992278 -12.4035" album="" material="bm_friction_grass" texgens="1 0 0 1536 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="462" owner="0" type="0" pos="6 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 11.5" />
                            <Vertex pos="-4 -4 11.5" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.298275 0 0.95448 -9.78342" album="" material="bm_friction_grass" texgens="1 0 0 1536 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="463" owner="0" type="0" pos="6 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 10" />
                            <Vertex pos="12 4 10" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 11" />
                            <Vertex pos="4 -4 11" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.124035 0 0.992278 -11.4112" album="" material="bm_friction_grass" texgens="1 0 0 1536 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="464" owner="0" type="0" pos="6 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 13" />
                            <Vertex pos="-4 -4 13" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 11" />
                            <Vertex pos="4 -4 11" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.242536 0 0.970143 -11.6417" album="" material="bm_friction_grass" texgens="1 0 0 1536 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="465" owner="0" type="0" pos="6 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 10" />
                            <Vertex pos="12 4 10" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 10.5" />
                            <Vertex pos="4 -4 10.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.0623783 0 0.998053 -10.7291" album="" material="bm_friction_grass" texgens="1 0 0 1536 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="466" owner="0" type="0" pos="6 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 11.5" />
                            <Vertex pos="-4 -4 11.5" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 10.5" />
                            <Vertex pos="4 -4 10.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.124035 0 0.992278 -10.9151" album="" material="bm_friction_grass" texgens="1 0 0 1536 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="468" owner="0" type="0" pos="30 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 4 11" />
                            <Vertex pos="-12 -4 11" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 11.3333" />
                            <Vertex pos="-4 -4 11.3333" />
                            <Vertex pos="-4 -4 -13" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.0416263 0 0.999133 -11.49" album="" material="bm_friction_grass" texgens="1 0 0 7680 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="470" owner="0" type="0" pos="30 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 4 11" />
                            <Vertex pos="-12 -4 11" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 12.3333" />
                            <Vertex pos="-4 -4 12.3333" />
                            <Vertex pos="-4 -4 -13" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.164395 0 0.986395 -12.8231" album="" material="bm_friction_grass" texgens="1 0 0 7680 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="471" owner="0" type="0" pos="30 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="12 -4 13" />
                            <Vertex pos="12 4 13" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 12.6667" />
                            <Vertex pos="4 -4 12.6667" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.0416263 0 0.999133 -12.4892" album="" material="bm_friction_grass" texgens="1 0 0 7680 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="472" owner="0" type="0" pos="30 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 11.3333" />
                            <Vertex pos="-4 -4 11.3333" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 12.6667" />
                            <Vertex pos="4 -4 12.6667" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.164407 0 0.986393 -11.8367" album="" material="bm_friction_grass" texgens="1 0 0 7680 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="473" owner="0" type="0" pos="30 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="12 -4 15.5" />
                            <Vertex pos="12 4 15.5" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 15.1667" />
                            <Vertex pos="4 -4 15.1667" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.0416263 0 0.999133 -14.987" album="" material="bm_friction_grass" texgens="1 0 0 7680 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="474" owner="0" type="0" pos="30 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 12.3333" />
                            <Vertex pos="-4 -4 12.3333" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 15.1667" />
                            <Vertex pos="4 -4 15.1667" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.333854 0 0.942625 -12.9611" album="" material="bm_friction_grass" texgens="1 0 0 7680 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="476" owner="0" type="0" pos="54 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 4 13" />
                            <Vertex pos="-12 -4 13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 13.8333" />
                            <Vertex pos="-4 -4 13.8333" />
                            <Vertex pos="-4 -4 -13" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.103602 0 0.994619 -14.1733" album="" material="bm_friction_grass" texgens="1 0 0 13824 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="478" owner="0" type="0" pos="54 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 4 15.5" />
                            <Vertex pos="-12 -4 15.5" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 14.8333" />
                            <Vertex pos="-4 -4 14.8333" />
                            <Vertex pos="-4 -4 -13" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.0830496 0 0.996545 -14.4499" album="" material="bm_friction_grass" texgens="1 0 0 13824 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="479" owner="0" type="0" pos="54 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="12 -4 13.5" />
                            <Vertex pos="12 4 13.5" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 14.1667" />
                            <Vertex pos="4 -4 14.1667" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.0830496 0 0.996545 -14.45" album="" material="bm_friction_grass" texgens="1 0 0 13824 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="480" owner="0" type="0" pos="54 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 13.8333" />
                            <Vertex pos="-4 -4 13.8333" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 14.1667" />
                            <Vertex pos="4 -4 14.1667" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.041639 0 0.999133 -13.9879" album="" material="bm_friction_grass" texgens="1 0 0 13824 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="481" owner="0" type="0" pos="54 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="12 -4 10.5" />
                            <Vertex pos="12 4 10.5" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 12.1667" />
                            <Vertex pos="4 -4 12.1667" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.203958 0 0.97898 -12.7268" album="" material="bm_friction_grass" texgens="1 0 0 13824 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="482" owner="0" type="0" pos="54 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 14.8333" />
                            <Vertex pos="-4 -4 14.8333" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 12.1667" />
                            <Vertex pos="4 -4 12.1667" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.316221 0 0.948686 -12.8073" album="" material="bm_friction_grass" texgens="1 0 0 13824 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="484" owner="0" type="0" pos="78 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 12.5" />
                            <Vertex pos="-12 -4 12.5" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 11.3333" />
                            <Vertex pos="-4 -4 11.3333" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.144311 0 0.989532 -10.6374" album="" material="bm_friction_grass" texgens="1 0 0 19968 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="486" owner="0" type="0" pos="78 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 9.5" />
                            <Vertex pos="-12 -4 9.5" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 8.83333" />
                            <Vertex pos="-4 -4 8.83333" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.0830459 0 0.996546 -8.47063" album="" material="bm_friction_grass" texgens="1 0 0 19968 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="487" owner="0" type="0" pos="78 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 8" />
                            <Vertex pos="12 4 8" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 9.16667" />
                            <Vertex pos="4 -4 9.16667" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.144307 0 0.989533 -9.64795" album="" material="bm_friction_grass" texgens="1 0 0 19968 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="488" owner="0" type="0" pos="78 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 11.3333" />
                            <Vertex pos="-4 -4 11.3333" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 9.16667" />
                            <Vertex pos="4 -4 9.16667" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.261411 0 0.965228 -9.89357" album="" material="bm_friction_grass" texgens="1 0 0 19968 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="489" owner="0" type="0" pos="78 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 10.5" />
                            <Vertex pos="12 4 10.5" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 9.16667" />
                            <Vertex pos="4 -4 9.16667" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.164399 0 0.986394 -8.38435" album="" material="bm_friction_grass" texgens="1 0 0 19968 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="490" owner="0" type="0" pos="78 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 8.83333" />
                            <Vertex pos="-4 -4 8.83333" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 9.16667" />
                            <Vertex pos="4 -4 9.16667" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.0416313 0 0.999133 -8.9922" album="" material="bm_friction_grass" texgens="1 0 0 19968 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="492" owner="0" type="0" pos="102 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 102 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 8" />
                            <Vertex pos="-12 -4 8" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 7.5" />
                            <Vertex pos="-4 -4 7.5" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.0623783 0 0.998053 -7.23588" album="" material="bm_friction_grass" texgens="1 0 0 26112 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="494" owner="0" type="0" pos="102 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 102 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 10.5" />
                            <Vertex pos="-12 -4 10.5" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 11" />
                            <Vertex pos="-4 -4 11" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.0623783 0 0.998053 -11.2281" album="" material="bm_friction_grass" texgens="1 0 0 26112 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="495" owner="0" type="0" pos="102 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 102 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 9.5" />
                            <Vertex pos="12 4 9.5" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 8" />
                            <Vertex pos="4 -4 8" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.184289 0 0.982872 -7.12582" album="" material="bm_friction_grass" texgens="1 0 0 26112 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="496" owner="0" type="0" pos="102 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 102 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 7.5" />
                            <Vertex pos="-4 -4 7.5" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 8" />
                            <Vertex pos="4 -4 8" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.0623783 0 0.998053 -7.73491" album="" material="bm_friction_grass" texgens="1 0 0 26112 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="497" owner="0" type="0" pos="102 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 102 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 11" />
                            <Vertex pos="12 4 11" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 10.5" />
                            <Vertex pos="4 -4 10.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.0623783 0 0.998053 -10.23" album="" material="bm_friction_grass" texgens="1 0 0 26112 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="498" owner="0" type="0" pos="102 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 102 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 11" />
                            <Vertex pos="-4 -4 11" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 10.5" />
                            <Vertex pos="4 -4 10.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.0623783 0 0.998053 -10.7291" album="" material="bm_friction_grass" texgens="1 0 0 26112 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="500" owner="0" type="0" pos="126 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 126 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 9.5" />
                            <Vertex pos="-12 -4 9.5" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 12.5" />
                            <Vertex pos="-4 -4 12.5" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.351123 0 0.936329 -13.1086" album="" material="bm_friction_grass" texgens="1 0 0 32256 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="502" owner="0" type="0" pos="126 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 126 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 11" />
                            <Vertex pos="-12 -4 11" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 13.5" />
                            <Vertex pos="-4 -4 13.5" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.298275 0 0.95448 -14.0786" album="" material="bm_friction_grass" texgens="1 0 0 32256 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="503" owner="0" type="0" pos="126 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 126 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 15" />
                            <Vertex pos="12 4 15" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 14.5" />
                            <Vertex pos="4 -4 14.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.0623783 0 0.998053 -14.2222" album="" material="bm_friction_grass" texgens="1 0 0 32256 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="504" owner="0" type="0" pos="126 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 126 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 12.5" />
                            <Vertex pos="-4 -4 12.5" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 14.5" />
                            <Vertex pos="4 -4 14.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.242536 0 0.970143 -13.0969" album="" material="bm_friction_grass" texgens="1 0 0 32256 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="505" owner="0" type="0" pos="126 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 126 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 17" />
                            <Vertex pos="12 4 17" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 16.5" />
                            <Vertex pos="4 -4 16.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.0623783 0 0.998053 -16.2184" album="" material="bm_friction_grass" texgens="1 0 0 32256 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="506" owner="0" type="0" pos="126 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 126 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 13.5" />
                            <Vertex pos="-4 -4 13.5" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 16.5" />
                            <Vertex pos="4 -4 16.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.351123 0 0.936329 -14.0449" album="" material="bm_friction_grass" texgens="1 0 0 32256 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="508" owner="0" type="0" pos="150 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 150 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 15" />
                            <Vertex pos="-12 -4 15" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 14.1667" />
                            <Vertex pos="-4 -4 14.1667" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.103602 0 0.994619 -13.6761" album="" material="bm_friction_grass" texgens="1 0 0 38400 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="510" owner="0" type="0" pos="150 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 150 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 17" />
                            <Vertex pos="-12 -4 17" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 15.1667" />
                            <Vertex pos="-4 -4 15.1667" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.223372 0 0.974733 -13.89" album="" material="bm_friction_grass" texgens="1 0 0 38400 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="511" owner="0" type="0" pos="150 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 150 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 9.5" />
                            <Vertex pos="12 4 9.5" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 12.3333" />
                            <Vertex pos="4 -4 12.3333" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.333844 0 0.942628 -12.9611" album="" material="bm_friction_grass" texgens="1 0 0 38400 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="512" owner="0" type="0" pos="150 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 150 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 14.1667" />
                            <Vertex pos="-4 -4 14.1667" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 12.3333" />
                            <Vertex pos="4 -4 12.3333" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.223384 0 0.974731 -12.9152" album="" material="bm_friction_grass" texgens="1 0 0 38400 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="513" owner="0" type="0" pos="150 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 150 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 9" />
                            <Vertex pos="12 4 9" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 10.8333" />
                            <Vertex pos="4 -4 10.8333" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.223372 0 0.974733 -11.4531" album="" material="bm_friction_grass" texgens="1 0 0 38400 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="514" owner="0" type="0" pos="150 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 150 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 15.1667" />
                            <Vertex pos="-4 -4 15.1667" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 10.8333" />
                            <Vertex pos="4 -4 10.8333" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.476289 0 0.879289 -11.4308" album="" material="bm_friction_grass" texgens="1 0 0 38400 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="516" owner="0" type="0" pos="174 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 174 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 4 10.5" />
                            <Vertex pos="-12 -4 10.5" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 10.1667" />
                            <Vertex pos="-4 -4 10.1667" />
                            <Vertex pos="-4 -4 -13" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.0416263 0 0.999133 -9.99138" album="" material="bm_friction_grass" texgens="1 0 0 44544 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="518" owner="0" type="0" pos="174 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 174 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 4 10" />
                            <Vertex pos="-12 -4 10" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 10.6667" />
                            <Vertex pos="-4 -4 10.6667" />
                            <Vertex pos="-4 -4 -13" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.0830496 0 0.996545 -10.962" album="" material="bm_friction_grass" texgens="1 0 0 44544 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="519" owner="0" type="0" pos="174 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 174 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="12 -4 13" />
                            <Vertex pos="12 4 13" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 12.3333" />
                            <Vertex pos="4 -4 12.3333" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.0830496 0 0.996545 -11.9585" album="" material="bm_friction_grass" texgens="1 0 0 44544 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="520" owner="0" type="0" pos="174 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 174 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 10.1667" />
                            <Vertex pos="-4 -4 10.1667" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 12.3333" />
                            <Vertex pos="4 -4 12.3333" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.261408 0 0.965228 -10.8588" album="" material="bm_friction_grass" texgens="1 0 0 44544 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="521" owner="0" type="0" pos="174 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 174 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="12 -4 14" />
                            <Vertex pos="12 4 14" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 13.3333" />
                            <Vertex pos="4 -4 13.3333" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.0830496 0 0.996545 -12.955" album="" material="bm_friction_grass" texgens="1 0 0 44544 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="522" owner="0" type="0" pos="174 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 174 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 10.6667" />
                            <Vertex pos="-4 -4 10.6667" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 13.3333" />
                            <Vertex pos="4 -4 13.3333" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.316221 0 0.948686 -11.3842" album="" material="bm_friction_grass" texgens="1 0 0 44544 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="524" owner="0" type="0" pos="198 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 198 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 4 13" />
                            <Vertex pos="-12 -4 13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 12.6667" />
                            <Vertex pos="-4 -4 12.6667" />
                            <Vertex pos="-4 -4 -13" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.0416263 0 0.999133 -12.4892" album="" material="bm_friction_grass" texgens="1 0 0 50688 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="526" owner="0" type="0" pos="198 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 198 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 13.1667" />
                            <Vertex pos="-4 -4 13.1667" />
                            <Vertex pos="-4 -4 -13" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="0.103602 0 0.994619 -12.6814" album="" material="bm_friction_grass" texgens="1 0 0 50688 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="527" owner="0" type="0" pos="198 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 198 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="12 -4 10.5" />
                            <Vertex pos="12 4 10.5" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 11.3333" />
                            <Vertex pos="4 -4 11.3333" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.103602 0 0.994619 -11.6867" album="" material="bm_friction_grass" texgens="1 0 0 50688 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="528" owner="0" type="0" pos="198 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 198 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 12.6667" />
                            <Vertex pos="-4 -4 12.6667" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 11.3333" />
                            <Vertex pos="4 -4 11.3333" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.164407 0 0.986393 -11.8367" album="" material="bm_friction_grass" texgens="1 0 0 50688 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="529" owner="0" type="0" pos="198 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 198 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="12 -4 9" />
                            <Vertex pos="12 4 9" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 9.83333" />
                            <Vertex pos="4 -4 9.83333" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="0.103606 0 0.994618 -10.1948" album="" material="bm_friction_grass" texgens="1 0 0 50688 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="530" owner="0" type="0" pos="198 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 198 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -13" />
                            <Vertex pos="-4 4 -13" />
                            <Vertex pos="-4 4 13.1667" />
                            <Vertex pos="-4 -4 13.1667" />
                            <Vertex pos="4 4 -13" />
                            <Vertex pos="4 4 9.83333" />
                            <Vertex pos="4 -4 9.83333" />
                            <Vertex pos="4 -4 -13" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0.384619 0 0.923075 -10.6154" album="" material="bm_friction_grass" texgens="1 0 0 50688 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="532" owner="0" type="0" pos="222 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 9.5" />
                            <Vertex pos="-12 -4 9.5" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 10" />
                            <Vertex pos="-4 -4 10" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.0623783 0 0.998053 -10.23" album="" material="bm_friction_grass" texgens="1 0 0 56832 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="534" owner="0" type="0" pos="222 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -4 -14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 4 8" />
                            <Vertex pos="-12 -4 8" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 9.5" />
                            <Vertex pos="-4 -4 9.5" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0.184289 0 0.982872 -10.0744" album="" material="bm_friction_grass" texgens="1 0 0 56832 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="535" owner="0" type="0" pos="222 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 14" />
                            <Vertex pos="12 4 14" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 11" />
                            <Vertex pos="4 -4 11" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.351123 0 0.936329 -8.89513" album="" material="bm_friction_grass" texgens="1 0 0 56832 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="536" owner="0" type="0" pos="222 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 10" />
                            <Vertex pos="-4 -4 10" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 11" />
                            <Vertex pos="4 -4 11" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.124035 0 0.992278 -10.4189" album="" material="bm_friction_grass" texgens="1 0 0 56832 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="537" owner="0" type="0" pos="222 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="12 -4 18" />
                            <Vertex pos="12 4 18" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 12.5" />
                            <Vertex pos="4 -4 12.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="15" plane="-0.566529 0 0.824042 -8.03441" album="" material="bm_friction_grass" texgens="1 0 0 56832 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="17" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="538" owner="0" type="0" pos="222 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 9.5" />
                            <Vertex pos="-4 -4 9.5" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 12.5" />
                            <Vertex pos="4 -4 12.5" />
                            <Vertex pos="4 -4 -14" />
                        </Vertices>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0.351123 0 0.936329 -10.2996" album="" material="bm_friction_grass" texgens="1 0 0 56832 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="16" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="17" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="540" owner="0" type="0" pos="-22 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16 4 -54" />
                            <Vertex pos="16 4 -54" />
                            <Vertex pos="16 4 18" />
                            <Vertex pos="-16 4 18" />
                            <Vertex pos="14 0 18" />
                            <Vertex pos="14 0 -54" />
                            <Vertex pos="-13 0 -54" />
                            <Vertex pos="-13 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.894427 -0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-0.8 -0.6 0 -10.4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="542" owner="0" type="0" pos="250 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16 4 -54" />
                            <Vertex pos="14 4 -54" />
                            <Vertex pos="14 4 18" />
                            <Vertex pos="-16 4 18" />
                            <Vertex pos="11 0 18" />
                            <Vertex pos="11 0 -54" />
                            <Vertex pos="-14 0 -54" />
                            <Vertex pos="-14 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.8 -0.6 0 -8.8" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-0.894429 -0.447211 0 -12.522" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="543" owner="0" type="0" pos="-13 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -9 -54" />
                            <Vertex pos="-7 -9 18" />
                            <Vertex pos="7 -9 18" />
                            <Vertex pos="7 -9 -54" />
                            <Vertex pos="7 -5 18" />
                            <Vertex pos="7 -5 -54" />
                            <Vertex pos="-7 -5 -54" />
                            <Vertex pos="-7 -5 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="545" owner="0" type="0" pos="-29 -28 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -4 -54" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -54" />
                            <Vertex pos="9 0 18" />
                            <Vertex pos="9 0 -54" />
                            <Vertex pos="-9.5 0 -54" />
                            <Vertex pos="-9.5 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-0.992278 -0.124035 0 -9.42664" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="546" owner="0" type="0" pos="-29 -28 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.5 4 -54" />
                            <Vertex pos="9 4 -54" />
                            <Vertex pos="9 4 18" />
                            <Vertex pos="-10.5 4 18" />
                            <Vertex pos="9 0 18" />
                            <Vertex pos="9 0 -54" />
                            <Vertex pos="-9.5 0 -54" />
                            <Vertex pos="-9.5 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-0.970142 -0.242536 0 -9.21635" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="547" owner="0" type="0" pos="241 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -9 -54" />
                            <Vertex pos="-7 -9 18" />
                            <Vertex pos="7 -9 18" />
                            <Vertex pos="7 -9 -54" />
                            <Vertex pos="7 -5 18" />
                            <Vertex pos="7 -5 -54" />
                            <Vertex pos="-7 -5 -54" />
                            <Vertex pos="-7 -5 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="549" owner="0" type="0" pos="257 -28 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 -28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -4 -54" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="7 -4 18" />
                            <Vertex pos="7 -4 -54" />
                            <Vertex pos="8 0 18" />
                            <Vertex pos="8 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.970142 -0.242536 0 -7.76114" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="550" owner="0" type="0" pos="257 -28 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 -28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 4 -54" />
                            <Vertex pos="10 4 -54" />
                            <Vertex pos="10 4 18" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="8 0 18" />
                            <Vertex pos="8 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.894427 -0.447214 0 -7.15542" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="551" owner="0" type="0" pos="-13 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -5 18" />
                            <Vertex pos="7 -5 18" />
                            <Vertex pos="7 -5 -18" />
                            <Vertex pos="-7 -5 -18" />
                            <Vertex pos="7 -1 18" />
                            <Vertex pos="7 -1 -18" />
                            <Vertex pos="-7 -1 -18" />
                            <Vertex pos="-7 -1 18" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="3.40598e-008 1 1.32455e-008 1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="553" owner="0" type="0" pos="241 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -5 18" />
                            <Vertex pos="7 -5 18" />
                            <Vertex pos="7 -5 -54" />
                            <Vertex pos="-7 -5 -54" />
                            <Vertex pos="7 -1 18" />
                            <Vertex pos="7 -1 -54" />
                            <Vertex pos="-7 -1 -54" />
                            <Vertex pos="-7 -1 18" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="-0 1 6.62274e-009 1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="555" owner="0" type="0" pos="-29 -20 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.5 -4 -54" />
                            <Vertex pos="-10.5 -4 18" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -54" />
                            <Vertex pos="9 0 17" />
                            <Vertex pos="9 0 -54" />
                            <Vertex pos="-13 0 -54" />
                            <Vertex pos="-13 0 17" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-0.847998 -0.529999 0 -11.024" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0.242536 0.970142 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="556" owner="0" type="0" pos="-29 -20 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14.5 4 -54" />
                            <Vertex pos="9 4 -54" />
                            <Vertex pos="9 4 15" />
                            <Vertex pos="-14.5 4 15" />
                            <Vertex pos="9 0 17" />
                            <Vertex pos="9 0 -54" />
                            <Vertex pos="-13 0 -54" />
                            <Vertex pos="-13 0 17" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-0.936329 -0.351123 0 -12.1723" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0.447214 0.894427 -15.2053" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="557" owner="0" type="0" pos="257 -20 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 -20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -4 -54" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="10 -4 18" />
                            <Vertex pos="10 -4 -54" />
                            <Vertex pos="11.5 0 17" />
                            <Vertex pos="11.5 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 17" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.936329 -0.351123 0 -10.7678" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0.242536 0.970142 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="558" owner="0" type="0" pos="257 -20 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 -20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 4 -54" />
                            <Vertex pos="14.5 4 -54" />
                            <Vertex pos="14.5 4 15" />
                            <Vertex pos="-9 4 15" />
                            <Vertex pos="11.5 0 17" />
                            <Vertex pos="11.5 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 17" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.8 -0.6 0 -9.2" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0.447214 0.894427 -15.2053" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="559" owner="0" type="0" pos="-13 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -1 18" />
                            <Vertex pos="7 -1 18" />
                            <Vertex pos="7 -1 -18" />
                            <Vertex pos="-7 -1 -18" />
                            <Vertex pos="7 3 18" />
                            <Vertex pos="7 3 -18" />
                            <Vertex pos="-7 3 -18" />
                            <Vertex pos="-7 3 18" />
                        </Vertices>
                        <Face id="18" plane="3.40598e-008 -1 1.32455e-008 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="20" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="21" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="22" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="23" plane="3.40598e-008 1 1.32455e-008 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="561" owner="0" type="0" pos="241 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -1 18" />
                            <Vertex pos="7 -1 18" />
                            <Vertex pos="7 -1 -18" />
                            <Vertex pos="-7 -1 -18" />
                            <Vertex pos="7 3 18" />
                            <Vertex pos="7 3 -18" />
                            <Vertex pos="-7 3 -18" />
                            <Vertex pos="-7 3 18" />
                        </Vertices>
                        <Face id="18" plane="3.40598e-008 -1 1.32455e-008 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="20" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="21" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="22" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="23" plane="3.40598e-008 1 1.32455e-008 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="563" owner="0" type="0" pos="-8 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="12" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-4 -6 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="-4 -2 16.5" />
                            <Vertex pos="-4 -6 16" />
                            <Vertex pos="0 -2 16.5" />
                            <Vertex pos="0 -2 -20" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="8" plane="0 -0.124035 0.992278 -16.6207" album="" material="bm_friction_grass" texgens="1 0 0 -2048 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="9" plane="-0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="10" plane="0 1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="565" owner="0" type="0" pos="-16 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 -20" />
                            <Vertex pos="-4 -6 16" />
                            <Vertex pos="4 -6 16" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="4 -2 16.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="-4 -2 16.5" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0 -0.124035 0.992278 -16.6207" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="2.98023e-008 1 6.53202e-009 2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="567" owner="0" type="0" pos="236 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="12" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="4 -5.99999 -20" />
                            <Vertex pos="4 -6 16" />
                            <Vertex pos="4 -2 16.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="0 -2 16.5" />
                            <Vertex pos="1.00136e-005 -2 -20" />
                        </Vertices>
                        <Face id="6" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -255.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="-0.707107 -0.707107 -1.96685e-007 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="8" plane="0 -0.124035 0.992278 -16.6207" album="" material="bm_friction_grass" texgens="1 0 0 60416 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 4" />
                        </Face>
                        <Face id="9" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 511.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 0 3" />
                        </Face>
                        <Face id="10" plane="-5.96048e-008 1 9.79802e-009 2" album="" material="bm_grid_blank4" texgens="1 0 0 -255.998 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="569" owner="0" type="0" pos="244 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 -20" />
                            <Vertex pos="-4 -6 16" />
                            <Vertex pos="4 -6 16" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="4 -2 16.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="-4 -2 16.5" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0 -0.124035 0.992278 -16.6207" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="2.98023e-008 1 6.53202e-009 2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="571" owner="0" type="0" pos="-13 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 3 18" />
                            <Vertex pos="7 3 18" />
                            <Vertex pos="7 3 -18" />
                            <Vertex pos="-7 3 -18" />
                            <Vertex pos="7 7 18" />
                            <Vertex pos="7 7 -18" />
                            <Vertex pos="-7 7 -18" />
                            <Vertex pos="-7 7 18" />
                        </Vertices>
                        <Face id="24" plane="3.40598e-008 -1 1.32455e-008 3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="27" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="28" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="29" plane="0 1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="572" owner="0" type="0" pos="-13 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 9 -18" />
                            <Vertex pos="7 9 -18" />
                            <Vertex pos="7 9 18" />
                            <Vertex pos="-7 9 18" />
                            <Vertex pos="7 7 18" />
                            <Vertex pos="7 7 -18" />
                            <Vertex pos="-7 7 -18" />
                            <Vertex pos="-7 7 18" />
                        </Vertices>
                        <Face id="24" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="27" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="28" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="29" plane="-0 -1 -0 7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="573" owner="0" type="0" pos="241 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 3 18" />
                            <Vertex pos="7 3 18" />
                            <Vertex pos="7 3 -18" />
                            <Vertex pos="-7 3 -18" />
                            <Vertex pos="7 7 18" />
                            <Vertex pos="7 7 -18" />
                            <Vertex pos="-7 7 -18" />
                            <Vertex pos="-7 7 18" />
                        </Vertices>
                        <Face id="24" plane="3.40598e-008 -1 1.32455e-008 3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="27" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="28" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="29" plane="0 1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="574" owner="0" type="0" pos="241 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 9 -18" />
                            <Vertex pos="7 9 -18" />
                            <Vertex pos="7 9 18" />
                            <Vertex pos="-7 9 18" />
                            <Vertex pos="7 7 18" />
                            <Vertex pos="7 7 -18" />
                            <Vertex pos="-7 7 -18" />
                            <Vertex pos="-7 7 18" />
                        </Vertices>
                        <Face id="24" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="27" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="28" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="29" plane="-0 -1 -0 7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="575" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14.5 -16 -52" />
                            <Vertex pos="-14.5 -16 17" />
                            <Vertex pos="9 -16 17" />
                            <Vertex pos="9 -16 -52" />
                            <Vertex pos="9 -12 16" />
                            <Vertex pos="9 -12 -52" />
                            <Vertex pos="-16.5 -12 -52" />
                            <Vertex pos="-16.5 -12 16" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-0.894427 -0.447214 0 -20.1246" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0.242536 0.970143 -12.6119" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="577" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -16 -52" />
                            <Vertex pos="-9 -16 17" />
                            <Vertex pos="14.5 -16 17" />
                            <Vertex pos="14.5 -16 -52" />
                            <Vertex pos="16 -12 16" />
                            <Vertex pos="16 -12 -52" />
                            <Vertex pos="-9 -12 -52" />
                            <Vertex pos="-9 -12 16" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.936329 -0.351123 0 -19.1947" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0.242536 0.970142 -12.6119" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="579" owner="0" type="0" pos="-8 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="20" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -2 16.5" />
                            <Vertex pos="4 2 17.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="0 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="-4 -2 16.5" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 17.5" />
                        </Vertices>
                        <Face id="13" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="14" plane="-5.96046e-008 -1 -6.53202e-009 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="15" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 6 7 5" />
                        </Face>
                        <Face id="16" plane="0 -0.242536 0.970143 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 -2048 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 7 1 0" />
                        </Face>
                        <Face id="17" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="18" plane="-1.49012e-008 1 -3.17891e-009 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="580" owner="0" type="0" pos="-8 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="20" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="4 2 17.5" />
                            <Vertex pos="4 6 20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 17.5" />
                        </Vertices>
                        <Face id="13" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="14" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="15" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 5 7" />
                        </Face>
                        <Face id="16" plane="0 -0.529999 0.847998 -13.78" album="" material="bm_friction_grass" texgens="1 0 0 -2048 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 2 1" />
                        </Face>
                        <Face id="17" plane="-0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 4 6" />
                        </Face>
                        <Face id="18" plane="-0 -1 -0 2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 1 0 6" />
                        </Face>
                    </Brush>
                    <Brush id="581" owner="0" type="0" pos="-16 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -2 16.5" />
                            <Vertex pos="4 -2 16.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="4 2 17.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 17.5" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0 -0.242536 0.970143 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="-1.49012e-008 1 -3.17891e-009 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="582" owner="0" type="0" pos="-16 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 6 20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="4 2 17.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 17.5" />
                        </Vertices>
                        <Face id="12" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="15" plane="0 -0.529999 0.847998 -13.78" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="17" plane="-0 -1 -0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="583" owner="0" type="0" pos="236 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="20" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2.00001 -20" />
                            <Vertex pos="-4 2 17.5" />
                            <Vertex pos="0 -2 16.5" />
                            <Vertex pos="1.00136e-005 -2 -20" />
                            <Vertex pos="4 -2 16.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="4 2 17.5" />
                            <Vertex pos="4 2 -20" />
                        </Vertices>
                        <Face id="13" plane="-0.707107 -0.707107 -1.88818e-007 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="14" plane="0 -1 -3.26601e-009 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -255.998 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="15" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -255.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 6 7 5" />
                        </Face>
                        <Face id="16" plane="0 -0.242536 0.970143 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 60416 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 6 4 2" />
                        </Face>
                        <Face id="17" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 511.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 7" />
                        </Face>
                        <Face id="18" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -255.998 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 1 0" />
                        </Face>
                    </Brush>
                    <Brush id="584" owner="0" type="0" pos="236 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="20" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2.00001 -20" />
                            <Vertex pos="-4 5.99999 -20" />
                            <Vertex pos="-4 5.99999 20" />
                            <Vertex pos="-4 2 17.5" />
                            <Vertex pos="4 5.99999 -20" />
                            <Vertex pos="4 5.99999 20" />
                            <Vertex pos="4 2 17.5" />
                            <Vertex pos="4 2 -20" />
                        </Vertices>
                        <Face id="13" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 511.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="14" plane="0 1 -0 -5.99999" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="15" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -255.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 5 4 7" />
                        </Face>
                        <Face id="16" plane="0 -0.53 0.847998 -13.78" album="" material="bm_friction_grass" texgens="1 0 0 60416 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="17" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 511.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="18" plane="-1.2517e-006 -1 -2.67029e-007 2" album="" material="bm_grid_blank4" texgens="1 0 0 -255.998 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                    </Brush>
                    <Brush id="585" owner="0" type="0" pos="244 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -2 16.5" />
                            <Vertex pos="4 -2 16.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="4 2 17.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 17.5" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="0 -0.242536 0.970143 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="-1.49012e-008 1 -3.17891e-009 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="586" owner="0" type="0" pos="244 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 6 20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="4 2 17.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 17.5" />
                        </Vertices>
                        <Face id="12" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="15" plane="0 -0.529999 0.847998 -13.78" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="17" plane="-0 -1 -0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="587" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.5 -12 16" />
                            <Vertex pos="9 -12 16" />
                            <Vertex pos="9 -12 -52" />
                            <Vertex pos="-16.5 -12 -52" />
                            <Vertex pos="9 -8 16" />
                            <Vertex pos="9 -8 -52" />
                            <Vertex pos="-17 -8 -52" />
                            <Vertex pos="-17 -8 16" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0.992278 -0.124035 0 -17.861" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="0 1 0 8" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="589" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -12 16" />
                            <Vertex pos="16 -12 16" />
                            <Vertex pos="16 -12 -52" />
                            <Vertex pos="-9 -12 -52" />
                            <Vertex pos="17 -8 16" />
                            <Vertex pos="17 -8 -52" />
                            <Vertex pos="-9 -8 -52" />
                            <Vertex pos="-9 -8 16" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0.970142 -0.242536 0 -18.4327" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="0 1 0 8" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="591" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-17 -8 16" />
                            <Vertex pos="9 -8 16" />
                            <Vertex pos="9 -8 -52" />
                            <Vertex pos="-17 -8 -52" />
                            <Vertex pos="9 -4 16" />
                            <Vertex pos="9 -4 -52" />
                            <Vertex pos="-16 -4 -52" />
                            <Vertex pos="-16 -4 16" />
                        </Vertices>
                        <Face id="18" plane="-0 -1 -0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="20" plane="-0.970142 0.242536 -8.50368e-010 -14.5521" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="21" plane="0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="22" plane="0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="23" plane="-9.53674e-009 1 -3.50616e-009 4" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="593" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -8 16" />
                            <Vertex pos="17 -8 16" />
                            <Vertex pos="17 -8 -52" />
                            <Vertex pos="-9 -8 -52" />
                            <Vertex pos="16.5 -4 16" />
                            <Vertex pos="16.5 -4 -52" />
                            <Vertex pos="-9 -4 -52" />
                            <Vertex pos="-9 -4 16" />
                        </Vertices>
                        <Face id="18" plane="-0 -1 -0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="0.992278 0.124035 4.34885e-010 -15.8764" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="20" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="21" plane="0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="22" plane="0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="23" plane="-9.34975e-009 1 -3.50616e-009 4" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="595" owner="0" type="0" pos="-16 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -22" />
                            <Vertex pos="-4 -4 21" />
                            <Vertex pos="4 -4 21" />
                            <Vertex pos="4 -4 -22" />
                            <Vertex pos="4 0 22" />
                            <Vertex pos="4 0 -22" />
                            <Vertex pos="-4 0 -22" />
                            <Vertex pos="-4 0 22" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0 -0.242536 0.970143 -21.3431" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="596" owner="0" type="0" pos="-16 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 4 -22" />
                            <Vertex pos="4 4 -22" />
                            <Vertex pos="4 4 21" />
                            <Vertex pos="-4 4 21" />
                            <Vertex pos="4 0 22" />
                            <Vertex pos="4 0 -22" />
                            <Vertex pos="-4 0 -22" />
                            <Vertex pos="-4 0 22" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0.242536 0.970143 -21.3431" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 -0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="597" owner="0" type="0" pos="244 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -22" />
                            <Vertex pos="-4 -4 21" />
                            <Vertex pos="4 -4 21" />
                            <Vertex pos="4 -4 -22" />
                            <Vertex pos="4 0 22" />
                            <Vertex pos="4 0 -22" />
                            <Vertex pos="-4 0 -22" />
                            <Vertex pos="-4 0 22" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0 -0.242536 0.970143 -21.3431" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="598" owner="0" type="0" pos="244 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 4 -22" />
                            <Vertex pos="4 4 -22" />
                            <Vertex pos="4 4 21" />
                            <Vertex pos="-4 4 21" />
                            <Vertex pos="4 0 22" />
                            <Vertex pos="4 0 -22" />
                            <Vertex pos="-4 0 -22" />
                            <Vertex pos="-4 0 22" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0.242536 0.970143 -21.3431" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 -0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="599" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16 -4 16" />
                            <Vertex pos="9 -4 16" />
                            <Vertex pos="9 -4 -52" />
                            <Vertex pos="-16 -4 -52" />
                            <Vertex pos="9 0 16" />
                            <Vertex pos="9 2.38419e-007 -52" />
                            <Vertex pos="-16.5 0 -52" />
                            <Vertex pos="-16.5 2.38419e-007 16" />
                        </Vertices>
                        <Face id="24" plane="-9.53674e-009 -1 -3.50616e-009 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="26" plane="-0.992278 -0.124035 4.34885e-010 -16.3726" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="27" plane="0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="28" plane="0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="29" plane="-9.34975e-009 1 -3.50616e-009 -3.36591e-007" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="601" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -4 16" />
                            <Vertex pos="16.5 -4 16" />
                            <Vertex pos="16.5 -4 -52" />
                            <Vertex pos="-9 -4 -52" />
                            <Vertex pos="15.5 0 16" />
                            <Vertex pos="15.5 2.38419e-007 -52" />
                            <Vertex pos="-9 0 -52" />
                            <Vertex pos="-9 2.38419e-007 16" />
                        </Vertices>
                        <Face id="24" plane="-9.34975e-009 -1 -3.50616e-009 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="0.970142 0.242536 8.50368e-010 -15.0372" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="27" plane="0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="28" plane="0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="29" plane="-9.73137e-009 1 -3.50616e-009 -2.69902e-007" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="603" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.5 2.38419e-007 16" />
                            <Vertex pos="9 0 16" />
                            <Vertex pos="9 2.38419e-007 -52" />
                            <Vertex pos="-16.5 0 -52" />
                            <Vertex pos="9 4 16" />
                            <Vertex pos="9 4 -52" />
                            <Vertex pos="-17.5 4 -52" />
                            <Vertex pos="-17.5 4 16" />
                        </Vertices>
                        <Face id="30" plane="-9.34975e-009 -1 -3.50616e-009 1.40246e-007" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="31" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="32" plane="-0.970142 -0.242536 0 -16.0074" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="33" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="34" plane="-0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="35" plane="0 1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="605" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 2.38419e-007 16" />
                            <Vertex pos="15.5 0 16" />
                            <Vertex pos="15.5 2.38419e-007 -52" />
                            <Vertex pos="-9 0 -52" />
                            <Vertex pos="16 4 16" />
                            <Vertex pos="16 4 -52" />
                            <Vertex pos="-9 4 -52" />
                            <Vertex pos="-9 4 16" />
                        </Vertices>
                        <Face id="30" plane="-9.73137e-009 -1 -3.50616e-009 2.06935e-007" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="31" plane="0.992278 -0.124035 0 -15.3803" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="32" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="33" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="34" plane="-0 0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="35" plane="0 1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="607" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="43" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-17.5 4 16" />
                            <Vertex pos="9 4 16" />
                            <Vertex pos="9 4 -52" />
                            <Vertex pos="-17.5 4 -52" />
                            <Vertex pos="9 8 16" />
                            <Vertex pos="9 8 -52" />
                            <Vertex pos="-18 8 -52" />
                            <Vertex pos="-18 8 16" />
                        </Vertices>
                        <Face id="36" plane="-0 -1 -0 4" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="37" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="38" plane="-0.992278 -0.124035 0 -16.8687" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="39" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="40" plane="-0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="41" plane="0 1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="609" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="43" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 4 16" />
                            <Vertex pos="16 4 16" />
                            <Vertex pos="16 4 -52" />
                            <Vertex pos="-9 4 -52" />
                            <Vertex pos="17 8 16" />
                            <Vertex pos="17 8 -52" />
                            <Vertex pos="-9 8 -52" />
                            <Vertex pos="-9 8 16" />
                        </Vertices>
                        <Face id="36" plane="-0 -1 -0 4" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="37" plane="0.970142 -0.242536 0 -14.5521" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="38" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="39" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="40" plane="-0 0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="41" plane="0 1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="611" owner="0" type="0" pos="-8 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="4 -6 20" />
                            <Vertex pos="4 -2 17.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="-4 -2 17.5" />
                        </Vertices>
                        <Face id="6" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 5 1 0" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 6 7 5" />
                        </Face>
                        <Face id="9" plane="-0 0.529999 0.847998 -13.78" album="" material="bm_friction_grass" texgens="1 0 0 -2048 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 7 2 1" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 3 6" />
                        </Face>
                        <Face id="11" plane="2.98023e-008 1 6.35783e-009 2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 3 2" />
                        </Face>
                    </Brush>
                    <Brush id="613" owner="0" type="0" pos="-16 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="4 -6 20" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="4 -2 17.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="-4 -2 17.5" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0.529999 0.847998 -13.78" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="2.98023e-008 1 6.35783e-009 2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="615" owner="0" type="0" pos="236 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -5.99999 -20" />
                            <Vertex pos="-4 -2.00001 -20" />
                            <Vertex pos="-4 -2 17.5" />
                            <Vertex pos="-4 -5.99999 20" />
                            <Vertex pos="4 -5.99999 20" />
                            <Vertex pos="4 -5.99999 -20" />
                            <Vertex pos="4 -2 17.5" />
                            <Vertex pos="4 -2 -20" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -511.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 -1 0 -5.99999" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="8" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 767.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0.53 0.847998 -13.78" album="" material="bm_friction_grass" texgens="1 0 0 60416 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -511.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="11" plane="0 1 9.53674e-009 2" album="" material="bm_grid_blank4" texgens="1 0 0 767.998 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="617" owner="0" type="0" pos="244 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="4 -6 20" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="4 -2 17.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="-4 -2 17.5" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0.529999 0.847998 -13.78" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="2.98023e-008 1 6.35783e-009 2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="619" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="49" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-18 8 16" />
                            <Vertex pos="9 8 16" />
                            <Vertex pos="9 8 -52" />
                            <Vertex pos="-18 8 -52" />
                            <Vertex pos="9 12 16" />
                            <Vertex pos="9 12 -52" />
                            <Vertex pos="-17.5 12 -52" />
                            <Vertex pos="-17.5 12 16" />
                        </Vertices>
                        <Face id="42" plane="-0 -1 -0 8" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="43" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="44" plane="-0.992278 0.124035 0 -18.8533" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="45" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="46" plane="-0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="47" plane="0 1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="620" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="49" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.5 16 -52" />
                            <Vertex pos="9 16 -52" />
                            <Vertex pos="9 16 17" />
                            <Vertex pos="-16.5 16 17" />
                            <Vertex pos="9 12 16" />
                            <Vertex pos="9 12 -52" />
                            <Vertex pos="-17.5 12 -52" />
                            <Vertex pos="-17.5 12 16" />
                        </Vertices>
                        <Face id="42" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="43" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="44" plane="-0.970142 0.242536 0 -19.8879" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="45" plane="0 -0.242536 0.970143 -12.6119" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="46" plane="-0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="47" plane="-0 -1 -0 12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="621" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="49" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 8 16" />
                            <Vertex pos="17 8 16" />
                            <Vertex pos="17 8 -52" />
                            <Vertex pos="-9 8 -52" />
                            <Vertex pos="17.5 12 16" />
                            <Vertex pos="17.5 12 -52" />
                            <Vertex pos="-9 12 -52" />
                            <Vertex pos="-9 12 16" />
                        </Vertices>
                        <Face id="42" plane="-0 -1 -0 8" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="43" plane="0.992278 -0.124035 0 -15.8764" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="44" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="45" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="46" plane="-0 0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="47" plane="0 1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="622" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="49" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 16 -52" />
                            <Vertex pos="17 16 -52" />
                            <Vertex pos="17 16 17" />
                            <Vertex pos="-9 16 17" />
                            <Vertex pos="17.5 12 16" />
                            <Vertex pos="17.5 12 -52" />
                            <Vertex pos="-9 12 -52" />
                            <Vertex pos="-9 12 16" />
                        </Vertices>
                        <Face id="42" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="43" plane="0.992278 0.124035 0 -18.8533" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="44" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="45" plane="0 -0.242536 0.970143 -12.6119" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="46" plane="-0 -0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="47" plane="-0 -1 -0 12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="623" owner="0" type="0" pos="-13 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -9 -18" />
                            <Vertex pos="-7 -9 18" />
                            <Vertex pos="7 -9 18" />
                            <Vertex pos="7 -9 -18" />
                            <Vertex pos="7 -7 18" />
                            <Vertex pos="7 -7 -18" />
                            <Vertex pos="-7 -7 -18" />
                            <Vertex pos="-7 -7 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="625" owner="0" type="0" pos="241 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -9 -18" />
                            <Vertex pos="-7 -9 18" />
                            <Vertex pos="7 -9 18" />
                            <Vertex pos="7 -9 -18" />
                            <Vertex pos="7 -7 18" />
                            <Vertex pos="7 -7 -18" />
                            <Vertex pos="-7 -7 -18" />
                            <Vertex pos="-7 -7 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="627" owner="0" type="0" pos="-8 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -2 17.5" />
                            <Vertex pos="4 -2 17.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="0 2 -20" />
                            <Vertex pos="0 2 16.5" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 16.5" />
                        </Vertices>
                        <Face id="11" plane="-0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="12" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="13" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="14" plane="-0 0.242536 0.970143 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 -2048 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 5 1" />
                        </Face>
                        <Face id="15" plane="0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="16" plane="-2.98023e-008 1 -3.26601e-009 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="628" owner="0" type="0" pos="-8 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="17" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="0 2 -20" />
                            <Vertex pos="0 2 16.5" />
                            <Vertex pos="-4 6 16" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 16.5" />
                        </Vertices>
                        <Face id="11" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="12" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="13" plane="0 0.124035 0.992278 -16.6207" album="" material="bm_friction_grass" texgens="1 0 0 -2048 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="14" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 0 4" />
                        </Face>
                        <Face id="15" plane="-0 -1 -0 2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="629" owner="0" type="0" pos="-16 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -2 17.5" />
                            <Vertex pos="4 -2 17.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="4 2 16.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 16.5" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0 0.242536 0.970143 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="-1.49012e-008 1 -3.26601e-009 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="630" owner="0" type="0" pos="-16 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 6 16" />
                            <Vertex pos="-4 6 16" />
                            <Vertex pos="4 2 16.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 16.5" />
                        </Vertices>
                        <Face id="12" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="15" plane="-0 0.124035 0.992278 -16.6207" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="17" plane="-0 -1 -0 2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="631" owner="0" type="0" pos="236 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2.00001 -20" />
                            <Vertex pos="-4 -2 17.5" />
                            <Vertex pos="4 -2 17.5" />
                            <Vertex pos="1.00136e-005 2 -20" />
                            <Vertex pos="0 2 16.5" />
                            <Vertex pos="4 2 16.5" />
                            <Vertex pos="4 2 -20" />
                        </Vertices>
                        <Face id="11" plane="1.2964e-006 -1 2.67029e-007 -2" album="" material="bm_grid_blank4" texgens="1 0 0 767.998 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="12" plane="-0.707107 0.707107 -1.963e-007 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 767.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="14" plane="-0 0.242536 0.970143 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 60416 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="15" plane="0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -511.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="632" owner="0" type="0" pos="236 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="17" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.00136e-005 2 -20" />
                            <Vertex pos="4 5.99999 -20" />
                            <Vertex pos="4 6 16" />
                            <Vertex pos="0 2 16.5" />
                            <Vertex pos="4 2 16.5" />
                            <Vertex pos="4 2 -20" />
                        </Vertices>
                        <Face id="11" plane="-0.707107 0.707107 -1.96685e-007 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="12" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 767.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="13" plane="0 0.124035 0.992278 -16.6207" album="" material="bm_friction_grass" texgens="1 0 0 60416 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="14" plane="0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -511.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0" />
                        </Face>
                        <Face id="15" plane="2.98024e-008 -1 3.26602e-009 2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 0 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="633" owner="0" type="0" pos="244 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -2 17.5" />
                            <Vertex pos="4 -2 17.5" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="-4 -2 -20" />
                            <Vertex pos="4 2 16.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 16.5" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0 0.242536 0.970143 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="-1.49012e-008 1 -3.26601e-009 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="634" owner="0" type="0" pos="244 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 6 16" />
                            <Vertex pos="-4 6 16" />
                            <Vertex pos="4 2 16.5" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 2 -20" />
                            <Vertex pos="-4 2 16.5" />
                        </Vertices>
                        <Face id="12" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="15" plane="-0 0.124035 0.992278 -16.6207" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="17" plane="-0 -1 -0 2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="635" owner="0" type="0" pos="-29 20 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.5 -4 -54" />
                            <Vertex pos="-16.5 -4 15" />
                            <Vertex pos="9 -4 15" />
                            <Vertex pos="9 -4 -54" />
                            <Vertex pos="9 0 17" />
                            <Vertex pos="9 0 -54" />
                            <Vertex pos="-13 0 -54" />
                            <Vertex pos="-13 0 17" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-0.752577 0.658505 0 -9.7835" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0 -0.447214 0.894427 -15.2053" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 -5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="636" owner="0" type="0" pos="-29 20 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.5 4 -54" />
                            <Vertex pos="9 4 -54" />
                            <Vertex pos="9 4 18" />
                            <Vertex pos="-10.5 4 18" />
                            <Vertex pos="9 0 17" />
                            <Vertex pos="9 0 -54" />
                            <Vertex pos="-13 0 -54" />
                            <Vertex pos="-13 0 17" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-0.847998 0.529999 0 -11.024" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="0 -0.242536 0.970142 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 -5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="637" owner="0" type="0" pos="257 20 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -4 -54" />
                            <Vertex pos="-9 -4 15" />
                            <Vertex pos="17 -4 15" />
                            <Vertex pos="17 -4 -54" />
                            <Vertex pos="15.5 0 17" />
                            <Vertex pos="15.5 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 17" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.936329 0.351123 0 -14.5131" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0 -0.447214 0.894427 -15.2053" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 -5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="638" owner="0" type="0" pos="257 20 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 4 -54" />
                            <Vertex pos="13 4 -54" />
                            <Vertex pos="13 4 18" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="15.5 0 17" />
                            <Vertex pos="15.5 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 17" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.847998 0.529999 0 -13.144" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="0 -0.242536 0.970142 -16.4924" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 -5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="639" owner="0" type="0" pos="-13 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -7 18" />
                            <Vertex pos="7 -7 18" />
                            <Vertex pos="7 -7 -18" />
                            <Vertex pos="-7 -7 -18" />
                            <Vertex pos="7 -3 18" />
                            <Vertex pos="7 -3 -18" />
                            <Vertex pos="-7 -3 -18" />
                            <Vertex pos="-7 -3 18" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="0 1 0 3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="641" owner="0" type="0" pos="241 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -7 18" />
                            <Vertex pos="7 -7 18" />
                            <Vertex pos="7 -7 -18" />
                            <Vertex pos="-7 -7 -18" />
                            <Vertex pos="7 -3 18" />
                            <Vertex pos="7 -3 -18" />
                            <Vertex pos="-7 -3 -18" />
                            <Vertex pos="-7 -3 18" />
                        </Vertices>
                        <Face id="12" plane="-0 -1 -0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="15" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="17" plane="0 1 0 3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="643" owner="0" type="0" pos="-13 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -3 18" />
                            <Vertex pos="7 -3 18" />
                            <Vertex pos="7 -3 -18" />
                            <Vertex pos="-7 -3 -18" />
                            <Vertex pos="7 1 18" />
                            <Vertex pos="7 1 -18" />
                            <Vertex pos="-7 1 -18" />
                            <Vertex pos="-7 1 18" />
                        </Vertices>
                        <Face id="18" plane="-0 -1 -0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="20" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="21" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="22" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="23" plane="2.55448e-008 1 9.93411e-009 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="645" owner="0" type="0" pos="241 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -3 18" />
                            <Vertex pos="7 -3 18" />
                            <Vertex pos="7 -3 -18" />
                            <Vertex pos="-7 -3 -18" />
                            <Vertex pos="7 1 18" />
                            <Vertex pos="7 1 -18" />
                            <Vertex pos="-7 1 -18" />
                            <Vertex pos="-7 1 18" />
                        </Vertices>
                        <Face id="18" plane="-0 -1 -0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="20" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="21" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="22" plane="-0 -0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="23" plane="2.55448e-008 1 9.93411e-009 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="647" owner="0" type="0" pos="-29 28 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.5 -4 -54" />
                            <Vertex pos="-10.5 -4 18" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -54" />
                            <Vertex pos="9 0 18" />
                            <Vertex pos="9 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-0.936329 0.351123 0 -8.42696" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="648" owner="0" type="0" pos="-29 28 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 4 -54" />
                            <Vertex pos="9 4 -54" />
                            <Vertex pos="9 4 18" />
                            <Vertex pos="-8 4 18" />
                            <Vertex pos="9 0 18" />
                            <Vertex pos="9 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-0.970142 0.242536 0 -8.73128" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="649" owner="0" type="0" pos="257 28 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -4 -54" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="13 -4 18" />
                            <Vertex pos="13 -4 -54" />
                            <Vertex pos="10 0 18" />
                            <Vertex pos="10 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.8 0.6 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="650" owner="0" type="0" pos="257 28 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 4 -54" />
                            <Vertex pos="8 4 -54" />
                            <Vertex pos="8 4 18" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="10 0 18" />
                            <Vertex pos="10 0 -54" />
                            <Vertex pos="-9 0 -54" />
                            <Vertex pos="-9 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.894427 0.447214 0 -8.94427" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="8" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="10" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="11" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="651" owner="0" type="0" pos="-13 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 1 18" />
                            <Vertex pos="7 1 18" />
                            <Vertex pos="7 1 -54" />
                            <Vertex pos="-7 1 -54" />
                            <Vertex pos="7 5 18" />
                            <Vertex pos="7 5 -54" />
                            <Vertex pos="-7 5 -54" />
                            <Vertex pos="-7 5 18" />
                        </Vertices>
                        <Face id="24" plane="2.55448e-008 -1 1.65568e-009 1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="27" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="28" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="29" plane="0 1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="652" owner="0" type="0" pos="-13 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 9 -54" />
                            <Vertex pos="7 9 -54" />
                            <Vertex pos="7 9 18" />
                            <Vertex pos="-7 9 18" />
                            <Vertex pos="7 5 18" />
                            <Vertex pos="7 5 -54" />
                            <Vertex pos="-7 5 -54" />
                            <Vertex pos="-7 5 18" />
                        </Vertices>
                        <Face id="24" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="27" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="28" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="29" plane="-0 -1 -0 5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="653" owner="0" type="0" pos="241 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 1 18" />
                            <Vertex pos="7 1 18" />
                            <Vertex pos="7 1 -54" />
                            <Vertex pos="-7 1 -54" />
                            <Vertex pos="7 5 18" />
                            <Vertex pos="7 5 -54" />
                            <Vertex pos="-7 5 -54" />
                            <Vertex pos="-7 5 18" />
                        </Vertices>
                        <Face id="24" plane="2.55448e-008 -1 1.65568e-009 1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="27" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="28" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="29" plane="0 1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="654" owner="0" type="0" pos="241 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 9 -54" />
                            <Vertex pos="7 9 -54" />
                            <Vertex pos="7 9 18" />
                            <Vertex pos="-7 9 18" />
                            <Vertex pos="7 5 18" />
                            <Vertex pos="7 5 -54" />
                            <Vertex pos="-7 5 -54" />
                            <Vertex pos="-7 5 18" />
                        </Vertices>
                        <Face id="24" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="26" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="27" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="28" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="29" plane="-0 -1 -0 5" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="655" owner="0" type="0" pos="-22 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15 -4 -54" />
                            <Vertex pos="-15 -4 18" />
                            <Vertex pos="16 -4 18" />
                            <Vertex pos="16 -4 -54" />
                            <Vertex pos="14 0 18" />
                            <Vertex pos="14 0 -54" />
                            <Vertex pos="-12.5 0 -54" />
                            <Vertex pos="-12.5 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.894427 0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-0.847998 0.529999 0 -10.6" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="657" owner="0" type="0" pos="250 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16 -4 -54" />
                            <Vertex pos="-16 -4 18" />
                            <Vertex pos="15 -4 18" />
                            <Vertex pos="15 -4 -54" />
                            <Vertex pos="12 0 18" />
                            <Vertex pos="12 0 -54" />
                            <Vertex pos="-14 0 -54" />
                            <Vertex pos="-14 0 18" />
                        </Vertices>
                        <Face id="6" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0.8 0.6 0 -9.6" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="-0.894429 0.447211 0 -12.522" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="660" owner="0" type="0" pos="-22 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="10">
                        <Vertices>
                            <Vertex pos="-12.5 0 -54" />
                            <Vertex pos="-8 4 -54" />
                            <Vertex pos="-8 4 18" />
                            <Vertex pos="-12.5 0 18" />
                            <Vertex pos="-2 6.5 -54" />
                            <Vertex pos="-2 6.5 18" />
                            <Vertex pos="-2 0 18" />
                            <Vertex pos="-2 6.5 -54" />
                            <Vertex pos="-2 0 -54" />
                        </Vertices>
                        <Face id="12" plane="-0.664364 0.747409 0 -8.30455" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="-0.384615 0.923077 0 -6.76923" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="15" plane="0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 1 0 8" />
                        </Face>
                        <Face id="16" plane="-0 -1 -0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 8 0" />
                        </Face>
                        <Face id="17" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 6 5 4 7" />
                        </Face>
                    </Brush>
                    <Brush id="661" owner="0" type="0" pos="-22 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="10">
                        <Vertices>
                            <Vertex pos="14 0 18" />
                            <Vertex pos="10 4 18" />
                            <Vertex pos="10 4 -54" />
                            <Vertex pos="14 0 -54" />
                            <Vertex pos="4 6 -54" />
                            <Vertex pos="4 6 18" />
                            <Vertex pos="4 0 18" />
                            <Vertex pos="4 6 -54" />
                            <Vertex pos="4 0 -54" />
                        </Vertices>
                        <Face id="18" plane="0.707107 0.707107 0 -9.89949" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="0.316228 0.948683 -0 -6.95701" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="20" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="21" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 7 8" />
                        </Face>
                        <Face id="22" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 8" />
                        </Face>
                        <Face id="23" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 7 5 6 4" />
                        </Face>
                    </Brush>
                    <Brush id="662" owner="0" type="0" pos="-22 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="11">
                        <Vertices>
                            <Vertex pos="-2 0 -54" />
                            <Vertex pos="-2 6.5 -54" />
                            <Vertex pos="-2 6.5 18" />
                            <Vertex pos="-2 0 18" />
                            <Vertex pos="-2 6.5 -54" />
                            <Vertex pos="4 6 -54" />
                            <Vertex pos="4 6 18" />
                            <Vertex pos="4 0 18" />
                            <Vertex pos="4 6 -54" />
                            <Vertex pos="4 0 -54" />
                        </Vertices>
                        <Face id="18" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4" />
                        </Face>
                        <Face id="19" plane="0.0830455 0.996546 -0 -6.31146" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 5 6 2" />
                        </Face>
                        <Face id="20" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 6 7 3" />
                        </Face>
                        <Face id="21" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 1 0 9" />
                        </Face>
                        <Face id="22" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 7 9 0" />
                        </Face>
                        <Face id="23" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 9 7 6 5 8" />
                        </Face>
                    </Brush>
                    <Brush id="664" owner="0" type="0" pos="-22 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="10">
                        <Vertices>
                            <Vertex pos="-8 -4 -54" />
                            <Vertex pos="-13 0 -54" />
                            <Vertex pos="-13 0 18" />
                            <Vertex pos="-8 -4 18" />
                            <Vertex pos="-2 -5.5 18" />
                            <Vertex pos="-2 -5.5 -54" />
                            <Vertex pos="-2 0 18" />
                            <Vertex pos="-2 -5.5 -54" />
                            <Vertex pos="-2 0 -54" />
                        </Vertices>
                        <Face id="12" plane="-0.624695 -0.780869 0 -8.12104" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="-0.242536 -0.970142 -0 -5.82086" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="14" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="15" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 8 1" />
                        </Face>
                        <Face id="16" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 1 8 6" />
                        </Face>
                        <Face id="17" plane="1 0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 5 4 6 7" />
                        </Face>
                    </Brush>
                    <Brush id="665" owner="0" type="0" pos="-22 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="10">
                        <Vertices>
                            <Vertex pos="10 -4 -54" />
                            <Vertex pos="10 -4 18" />
                            <Vertex pos="14 0 18" />
                            <Vertex pos="14 0 -54" />
                            <Vertex pos="4 -6 18" />
                            <Vertex pos="4 -6 -54" />
                            <Vertex pos="4 0 18" />
                            <Vertex pos="4 -6 -54" />
                            <Vertex pos="4 0 -54" />
                        </Vertices>
                        <Face id="18" plane="0.707107 -0.707107 0 -9.89949" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="0.316228 -0.948683 0 -6.95701" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="20" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 1 4" />
                        </Face>
                        <Face id="21" plane="-0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 8" />
                        </Face>
                        <Face id="22" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 3 2 6" />
                        </Face>
                        <Face id="23" plane="-1 -0 -0 4" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 6 4 7 5" />
                        </Face>
                    </Brush>
                    <Brush id="666" owner="0" type="0" pos="-22 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="11">
                        <Vertices>
                            <Vertex pos="-2 0 -54" />
                            <Vertex pos="-2 0 18" />
                            <Vertex pos="-2 -5.5 18" />
                            <Vertex pos="-2 -5.5 -54" />
                            <Vertex pos="-2 -5.5 -54" />
                            <Vertex pos="4 -6 18" />
                            <Vertex pos="4 -6 -54" />
                            <Vertex pos="4 0 18" />
                            <Vertex pos="4 -6 -54" />
                            <Vertex pos="4 0 -54" />
                        </Vertices>
                        <Face id="18" plane="-1 -0 -0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4" />
                        </Face>
                        <Face id="19" plane="-0.0830455 -0.996546 -0 -5.64709" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 4" />
                        </Face>
                        <Face id="20" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 5 2" />
                        </Face>
                        <Face id="21" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 8 9 0" />
                        </Face>
                        <Face id="22" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 9 7 1" />
                        </Face>
                        <Face id="23" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 9 6 5 7 8" />
                        </Face>
                    </Brush>
                    <Brush id="668" owner="0" type="0" pos="250 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -4 -54" />
                            <Vertex pos="-14 0 -54" />
                            <Vertex pos="-14 0 18" />
                            <Vertex pos="-10 -4 18" />
                            <Vertex pos="-6 -6 18" />
                            <Vertex pos="-6 -6 -54" />
                            <Vertex pos="-6 0 18" />
                            <Vertex pos="-6 0 -54" />
                        </Vertices>
                        <Face id="12" plane="-0.707108 -0.707105 0 -9.89952" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="-0.447211 -0.894428 -0 -8.04984" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="14" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="15" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="16" plane="0 1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 1 7 6" />
                        </Face>
                        <Face id="17" plane="1 0 0 6" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="670" owner="0" type="0" pos="250 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="10">
                        <Vertices>
                            <Vertex pos="-6 0 -54" />
                            <Vertex pos="-6 0 18" />
                            <Vertex pos="-6 -6 18" />
                            <Vertex pos="-6 -6 -54" />
                            <Vertex pos="-2 -7 18" />
                            <Vertex pos="-2 -7 -54" />
                            <Vertex pos="-2 0 18" />
                            <Vertex pos="-2 -7 -54" />
                            <Vertex pos="-2 0 -54" />
                        </Vertices>
                        <Face id="18" plane="-1 -0 -0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="-0.242536 -0.970142 -0 -7.27607" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="20" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 6 4 2" />
                        </Face>
                        <Face id="21" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 7 8 0" />
                        </Face>
                        <Face id="22" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 8 6 1" />
                        </Face>
                        <Face id="23" plane="1 3.40598e-008 -0 2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 5 4 6 7" />
                        </Face>
                    </Brush>
                    <Brush id="671" owner="0" type="0" pos="250 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="10">
                        <Vertices>
                            <Vertex pos="6 -5 -54" />
                            <Vertex pos="6 -5 18" />
                            <Vertex pos="11 0 18" />
                            <Vertex pos="11 0 -54" />
                            <Vertex pos="2 -6.5 18" />
                            <Vertex pos="2 -6.5 -54" />
                            <Vertex pos="2 0 18" />
                            <Vertex pos="2 -6.5 -54" />
                            <Vertex pos="2 0 -54" />
                        </Vertices>
                        <Face id="24" plane="0.707107 -0.707107 0 -7.77818" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="0.351123 -0.936329 0 -6.78839" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="26" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 1 4" />
                        </Face>
                        <Face id="27" plane="-0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 8" />
                        </Face>
                        <Face id="28" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 3 2 6" />
                        </Face>
                        <Face id="29" plane="-1 0 4.96705e-009 2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 6 4 7 5" />
                        </Face>
                    </Brush>
                    <Brush id="672" owner="0" type="0" pos="250 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="11">
                        <Vertices>
                            <Vertex pos="-2 0 -54" />
                            <Vertex pos="-2 0 18" />
                            <Vertex pos="-2 -7 18" />
                            <Vertex pos="-2 -7 -54" />
                            <Vertex pos="-2 -7 -54" />
                            <Vertex pos="2 -6.5 18" />
                            <Vertex pos="2 -6.5 -54" />
                            <Vertex pos="2 0 18" />
                            <Vertex pos="2 -6.5 -54" />
                            <Vertex pos="2 0 -54" />
                        </Vertices>
                        <Face id="24" plane="-1 0 3.31137e-009 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4" />
                        </Face>
                        <Face id="25" plane="0.124035 -0.992278 0 -6.69788" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 5 6 4" />
                        </Face>
                        <Face id="26" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 1 7 5 2" />
                        </Face>
                        <Face id="27" plane="-0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 8 9 0" />
                        </Face>
                        <Face id="28" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 9 7 1" />
                        </Face>
                        <Face id="29" plane="1 5.50197e-008 -0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 9 6 5 7 8" />
                        </Face>
                    </Brush>
                    <Brush id="674" owner="0" type="0" pos="250 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14 0 -54" />
                            <Vertex pos="-10 4 -54" />
                            <Vertex pos="-10 4 18" />
                            <Vertex pos="-14 0 18" />
                            <Vertex pos="-6 6 -54" />
                            <Vertex pos="-6 6 18" />
                            <Vertex pos="-6 0 18" />
                            <Vertex pos="-6 0 -54" />
                        </Vertices>
                        <Face id="12" plane="-0.707108 0.707105 0 -9.89952" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="-0.447211 0.894428 0 -8.04984" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="15" plane="0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="16" plane="-0 -1 -0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="17" plane="1 -0 0 6" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="676" owner="0" type="0" pos="250 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="25" nextVertexID="10">
                        <Vertices>
                            <Vertex pos="-6 0 -54" />
                            <Vertex pos="-6 6 -54" />
                            <Vertex pos="-6 6 18" />
                            <Vertex pos="-6 0 18" />
                            <Vertex pos="-2 6.5 -54" />
                            <Vertex pos="-2 6.5 18" />
                            <Vertex pos="-2 0 18" />
                            <Vertex pos="-2 6.5 -54" />
                            <Vertex pos="-2 0 -54" />
                        </Vertices>
                        <Face id="18" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="19" plane="-0.124035 0.992278 0 -6.69788" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="20" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="21" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 1 0 8" />
                        </Face>
                        <Face id="22" plane="-0 -1 -0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 6 8 0" />
                        </Face>
                        <Face id="23" plane="1 -7.33596e-008 3.31137e-009 2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 6 5 4 7" />
                        </Face>
                    </Brush>
                    <Brush id="677" owner="0" type="0" pos="250 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="10">
                        <Vertices>
                            <Vertex pos="12 0 18" />
                            <Vertex pos="6 4 18" />
                            <Vertex pos="6 4 -54" />
                            <Vertex pos="12 0 -54" />
                            <Vertex pos="2 5.5 -54" />
                            <Vertex pos="2 5.5 18" />
                            <Vertex pos="2 0 18" />
                            <Vertex pos="2 5.5 -54" />
                            <Vertex pos="2 0 -54" />
                        </Vertices>
                        <Face id="24" plane="0.5547 0.83205 0 -6.6564" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="25" plane="0.351123 0.936329 -0 -5.85206" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="26" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="27" plane="-0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 7 8" />
                        </Face>
                        <Face id="28" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 0 3 8" />
                        </Face>
                        <Face id="29" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 7 5 6 4" />
                        </Face>
                    </Brush>
                    <Brush id="678" owner="0" type="0" pos="250 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="31" nextVertexID="11">
                        <Vertices>
                            <Vertex pos="-2 0 -54" />
                            <Vertex pos="-2 6.5 -54" />
                            <Vertex pos="-2 6.5 18" />
                            <Vertex pos="-2 0 18" />
                            <Vertex pos="-2 6.5 -54" />
                            <Vertex pos="2 5.5 -54" />
                            <Vertex pos="2 5.5 18" />
                            <Vertex pos="2 0 18" />
                            <Vertex pos="2 5.5 -54" />
                            <Vertex pos="2 0 -54" />
                        </Vertices>
                        <Face id="24" plane="-1 3.66798e-008 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4" />
                        </Face>
                        <Face id="25" plane="0.242536 0.970142 -0 -5.82085" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 5 6 2" />
                        </Face>
                        <Face id="26" plane="0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 6 7 3" />
                        </Face>
                        <Face id="27" plane="0 -0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 8 1 0 9" />
                        </Face>
                        <Face id="28" plane="-0 -1 -0 0" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 7 9 0" />
                        </Face>
                        <Face id="29" plane="1 -1.08372e-007 8.27842e-009 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 9 7 6 5 8" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
