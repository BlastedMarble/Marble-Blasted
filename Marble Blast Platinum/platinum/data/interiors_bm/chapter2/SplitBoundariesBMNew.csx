<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/05/19 14:25:59">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="1" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="32" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="375">
                    <Brush id="0" owner="0" type="0" pos="0 0 -13" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 14" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 -4 14" />
                            <Vertex pos="4 -4 -14" />
                            <Vertex pos="-4 4 14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 -4 14" />
                            <Vertex pos="-4 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="2 6 -13" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 6 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14" />
                            <Vertex pos="2 2 -14" />
                            <Vertex pos="2 -2 14" />
                            <Vertex pos="2 -2 -14" />
                            <Vertex pos="-2 2 14" />
                            <Vertex pos="-2 2 -14" />
                            <Vertex pos="-2 -2 14" />
                            <Vertex pos="-2 -2 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="2 6 1.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 6 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 1536 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -1536 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="2 9 -12.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 9 0 0 1 -12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 14.25" />
                            <Vertex pos="2 1 -14.25" />
                            <Vertex pos="2 -1 14.25" />
                            <Vertex pos="2 -1 -14.25" />
                            <Vertex pos="-2 1 14.25" />
                            <Vertex pos="-2 1 -14.25" />
                            <Vertex pos="-2 -1 14.25" />
                            <Vertex pos="-2 -1 -14.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="2 12 -12.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 12 0 0 1 -12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14.5" />
                            <Vertex pos="2 2 -14.5" />
                            <Vertex pos="2 -2 14.5" />
                            <Vertex pos="2 -2 -14.5" />
                            <Vertex pos="-2 2 14.5" />
                            <Vertex pos="-2 2 -14.5" />
                            <Vertex pos="-2 -2 14.5" />
                            <Vertex pos="-2 -2 -14.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.5" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="2 15 -12.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 15 0 0 1 -12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 14.25" />
                            <Vertex pos="2 1 -14.25" />
                            <Vertex pos="2 -1 14.25" />
                            <Vertex pos="2 -1 -14.25" />
                            <Vertex pos="-2 1 14.25" />
                            <Vertex pos="-2 1 -14.25" />
                            <Vertex pos="-2 -1 14.25" />
                            <Vertex pos="-2 -1 -14.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="2 18 -13" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 18 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14" />
                            <Vertex pos="2 2 -14" />
                            <Vertex pos="2 -2 14" />
                            <Vertex pos="2 -2 -14" />
                            <Vertex pos="-2 2 14" />
                            <Vertex pos="-2 2 -14" />
                            <Vertex pos="-2 -2 14" />
                            <Vertex pos="-2 -2 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="0 26 -13" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 26 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 14" />
                            <Vertex pos="4 6 -14" />
                            <Vertex pos="4 -6 14" />
                            <Vertex pos="4 -6 -14" />
                            <Vertex pos="-4 6 14" />
                            <Vertex pos="-4 6 -14" />
                            <Vertex pos="-4 -6 14" />
                            <Vertex pos="-4 -6 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="8 28 -13.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 28 0 0 1 -13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 13.75" />
                            <Vertex pos="2 4 -13.75" />
                            <Vertex pos="2 -4 13.75" />
                            <Vertex pos="2 -4 -13.75" />
                            <Vertex pos="-2 4 13.75" />
                            <Vertex pos="-2 4 -13.75" />
                            <Vertex pos="-2 -4 13.75" />
                            <Vertex pos="-2 -4 -13.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 7168 0 0 -1 3392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 1824 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1824 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 1824 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.75" album="" material="bm_tile03_A" texgens="1 0 0 -1024 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.75" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="14 30 -13.5" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 30 0 0 1 -13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 13.5" />
                            <Vertex pos="4 2 -13.5" />
                            <Vertex pos="4 -2 13.5" />
                            <Vertex pos="4 -2 -13.5" />
                            <Vertex pos="-4 2 13.5" />
                            <Vertex pos="-4 2 -13.5" />
                            <Vertex pos="-4 -2 13.5" />
                            <Vertex pos="-4 -2 -13.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 7680 0 0 -1 3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.5" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="12 26 -13.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 26 0 0 1 -13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13.75" />
                            <Vertex pos="2 2 -13.75" />
                            <Vertex pos="2 -2 13.75" />
                            <Vertex pos="2 -2 -13.75" />
                            <Vertex pos="-2 2 13.75" />
                            <Vertex pos="-2 2 -13.75" />
                            <Vertex pos="-2 -2 13.75" />
                            <Vertex pos="-2 -2 -13.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 6656 0 0 -1 3392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1824 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -3072 0 0 -1 3392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 1824 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.75" album="" material="bm_tile03_A" texgens="1 0 0 -1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.75" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="18 26 -13.5" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 26 0 0 1 -13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 13.5" />
                            <Vertex pos="4 2 -13.5" />
                            <Vertex pos="4 -2 13.5" />
                            <Vertex pos="4 -2 -13.5" />
                            <Vertex pos="-4 2 13.5" />
                            <Vertex pos="-4 2 -13.5" />
                            <Vertex pos="-4 -2 13.5" />
                            <Vertex pos="-4 -2 -13.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -4608 0 0 -1 3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.5" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="22 32 -13.75" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 32 0 0 1 -13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 13.25" />
                            <Vertex pos="4 4 -13.25" />
                            <Vertex pos="4 -4 13.25" />
                            <Vertex pos="4 -4 -13.25" />
                            <Vertex pos="-4 4 13.25" />
                            <Vertex pos="-4 4 -13.25" />
                            <Vertex pos="-4 -4 13.25" />
                            <Vertex pos="-4 -4 -13.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.25" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="24 38 -13.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 38 0 0 1 -13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13.25" />
                            <Vertex pos="2 2 -13.25" />
                            <Vertex pos="2 -2 13.25" />
                            <Vertex pos="2 -2 -13.25" />
                            <Vertex pos="-2 2 13.25" />
                            <Vertex pos="-2 2 -13.25" />
                            <Vertex pos="-2 -2 13.25" />
                            <Vertex pos="-2 -2 -13.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="20 40 -13.5" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 40 0 0 1 -13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 13.5" />
                            <Vertex pos="2 4 -13.5" />
                            <Vertex pos="2 -4 13.5" />
                            <Vertex pos="2 -4 -13.5" />
                            <Vertex pos="-2 4 13.5" />
                            <Vertex pos="-2 4 -13.5" />
                            <Vertex pos="-2 -4 13.5" />
                            <Vertex pos="-2 -4 -13.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 10240 0 0 -1 3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 5120 0 0 -1 3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.5" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="24 42 -13.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 42 0 0 1 -13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13.5" />
                            <Vertex pos="2 2 -13.5" />
                            <Vertex pos="2 -2 13.5" />
                            <Vertex pos="2 -2 -13.5" />
                            <Vertex pos="-2 2 13.5" />
                            <Vertex pos="-2 2 -13.5" />
                            <Vertex pos="-2 -2 13.5" />
                            <Vertex pos="-2 -2 -13.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.5" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="24 46 -13" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 46 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14" />
                            <Vertex pos="2 2 -14" />
                            <Vertex pos="2 -2 14" />
                            <Vertex pos="2 -2 -14" />
                            <Vertex pos="-2 2 14" />
                            <Vertex pos="-2 2 -14" />
                            <Vertex pos="-2 -2 14" />
                            <Vertex pos="-2 -2 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="22 50 -12.75" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 50 0 0 1 -12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 14.25" />
                            <Vertex pos="4 2 -14.25" />
                            <Vertex pos="4 -2 14.25" />
                            <Vertex pos="4 -2 -14.25" />
                            <Vertex pos="-4 2 14.25" />
                            <Vertex pos="-4 2 -14.25" />
                            <Vertex pos="-4 -2 14.25" />
                            <Vertex pos="-4 -2 -14.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.25" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="20 46 -13.5" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 46 0 0 1 -13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13.5" />
                            <Vertex pos="2 2 -13.5" />
                            <Vertex pos="2 -2 13.5" />
                            <Vertex pos="2 -2 -13.5" />
                            <Vertex pos="-2 2 13.5" />
                            <Vertex pos="-2 2 -13.5" />
                            <Vertex pos="-2 -2 13.5" />
                            <Vertex pos="-2 -2 -13.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.5" album="" material="bm_physics_repulsion" texgens="1 0 0 5120 0 -1 0 -11776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="17 64 -10" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 64 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 17" />
                            <Vertex pos="3 4 -17" />
                            <Vertex pos="3 -4 17" />
                            <Vertex pos="3 -4 -17" />
                            <Vertex pos="-3 4 17" />
                            <Vertex pos="-3 4 -17" />
                            <Vertex pos="-3 -4 17" />
                            <Vertex pos="-3 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 896 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile03_A" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="12 64 -10" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 64 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_physics_repulsion" texgens="1 0 0 3072 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="4 64 -8" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 64 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 19" />
                            <Vertex pos="2 4 -19" />
                            <Vertex pos="2 -4 19" />
                            <Vertex pos="2 -4 -19" />
                            <Vertex pos="-2 4 19" />
                            <Vertex pos="-2 4 -19" />
                            <Vertex pos="-2 -4 19" />
                            <Vertex pos="-2 -4 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="0 62 -8" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 62 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19" />
                            <Vertex pos="2 2 -19" />
                            <Vertex pos="2 -2 19" />
                            <Vertex pos="2 -2 -19" />
                            <Vertex pos="-2 2 19" />
                            <Vertex pos="-2 2 -19" />
                            <Vertex pos="-2 -2 19" />
                            <Vertex pos="-2 -2 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="0 66 -7.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 66 0 0 1 -7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19.25" />
                            <Vertex pos="2 2 -19.25" />
                            <Vertex pos="2 -2 19.25" />
                            <Vertex pos="2 -2 -19.25" />
                            <Vertex pos="-2 2 19.25" />
                            <Vertex pos="-2 2 -19.25" />
                            <Vertex pos="-2 -2 19.25" />
                            <Vertex pos="-2 -2 -19.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.25" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-4 66 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 66 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19.5" />
                            <Vertex pos="2 2 -19.5" />
                            <Vertex pos="2 -2 19.5" />
                            <Vertex pos="2 -2 -19.5" />
                            <Vertex pos="-2 2 19.5" />
                            <Vertex pos="-2 2 -19.5" />
                            <Vertex pos="-2 -2 19.5" />
                            <Vertex pos="-2 -2 -19.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.5" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-20 64 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 64 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 19.75" />
                            <Vertex pos="2 4 -19.75" />
                            <Vertex pos="2 -4 19.75" />
                            <Vertex pos="2 -4 -19.75" />
                            <Vertex pos="-2 4 19.75" />
                            <Vertex pos="-2 4 -19.75" />
                            <Vertex pos="-2 -4 19.75" />
                            <Vertex pos="-2 -4 -19.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.75" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="24 54 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 54 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14.75" />
                            <Vertex pos="2 2 -14.75" />
                            <Vertex pos="2 -2 14.75" />
                            <Vertex pos="2 -2 -14.75" />
                            <Vertex pos="-2 2 14.75" />
                            <Vertex pos="-2 2 -14.75" />
                            <Vertex pos="-2 -2 14.75" />
                            <Vertex pos="-2 -2 -14.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -13824 0 0 -1 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 6144 0 0 -1 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.75" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="20 54 -12.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 54 0 0 1 -12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14.25" />
                            <Vertex pos="2 2 -14.25" />
                            <Vertex pos="2 -2 14.25" />
                            <Vertex pos="2 -2 -14.25" />
                            <Vertex pos="-2 2 14.25" />
                            <Vertex pos="-2 2 -14.25" />
                            <Vertex pos="-2 -2 14.25" />
                            <Vertex pos="-2 -2 -14.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.25" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="24 58 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 58 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14.75" />
                            <Vertex pos="2 2 -14.75" />
                            <Vertex pos="2 -2 14.75" />
                            <Vertex pos="2 -2 -14.75" />
                            <Vertex pos="-2 2 14.75" />
                            <Vertex pos="-2 2 -14.75" />
                            <Vertex pos="-2 -2 14.75" />
                            <Vertex pos="-2 -2 -14.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.75" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="20 58 -13" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 58 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14" />
                            <Vertex pos="2 2 -14" />
                            <Vertex pos="2 -2 14" />
                            <Vertex pos="2 -2 -14" />
                            <Vertex pos="-2 2 14" />
                            <Vertex pos="-2 2 -14" />
                            <Vertex pos="-2 -2 14" />
                            <Vertex pos="-2 -2 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_physics_repulsion" texgens="1 0 0 5120 0 -1 0 -14848 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="23 64 -11.25" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 64 0 0 1 -11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 15.75" />
                            <Vertex pos="1 4 -15.75" />
                            <Vertex pos="1 -4 15.75" />
                            <Vertex pos="1 -4 -15.75" />
                            <Vertex pos="-1 4 15.75" />
                            <Vertex pos="-1 4 -15.75" />
                            <Vertex pos="-1 -4 15.75" />
                            <Vertex pos="-1 -4 -15.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15.75" album="" material="bm_physics_repulsion" texgens="1 0 0 5888 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="28 60 -12" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 60 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 15" />
                            <Vertex pos="2 4 -15" />
                            <Vertex pos="2 -4 15" />
                            <Vertex pos="2 -4 -15" />
                            <Vertex pos="-2 4 15" />
                            <Vertex pos="-2 4 -15" />
                            <Vertex pos="-2 -4 15" />
                            <Vertex pos="-2 -4 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="25 62 -11.75" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 62 0 0 1 -11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 15.25" />
                            <Vertex pos="1 2 -15.25" />
                            <Vertex pos="1 -2 15.25" />
                            <Vertex pos="1 -2 -15.25" />
                            <Vertex pos="-1 2 15.25" />
                            <Vertex pos="-1 2 -15.25" />
                            <Vertex pos="-1 -2 15.25" />
                            <Vertex pos="-1 -2 -15.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15.25" album="" material="bm_tile03_A" texgens="1 0 0 768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="26 66 -11.5" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 66 0 0 1 -11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15.5" />
                            <Vertex pos="2 2 -15.5" />
                            <Vertex pos="2 -2 15.5" />
                            <Vertex pos="2 -2 -15.5" />
                            <Vertex pos="-2 2 15.5" />
                            <Vertex pos="-2 2 -15.5" />
                            <Vertex pos="-2 -2 15.5" />
                            <Vertex pos="-2 -2 -15.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15.5" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-6 88 -11" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 88 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 4 16" />
                            <Vertex pos="8 4 -16" />
                            <Vertex pos="8 -4 16" />
                            <Vertex pos="8 -4 -16" />
                            <Vertex pos="-8 4 16" />
                            <Vertex pos="-8 4 -16" />
                            <Vertex pos="-8 -4 16" />
                            <Vertex pos="-8 -4 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile03_A" texgens="1 0 0 3584 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-2 96 -11" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 96 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 16" />
                            <Vertex pos="4 4 -16" />
                            <Vertex pos="4 -4 16" />
                            <Vertex pos="4 -4 -16" />
                            <Vertex pos="-4 4 16" />
                            <Vertex pos="-4 4 -16" />
                            <Vertex pos="-4 -4 16" />
                            <Vertex pos="-4 -4 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile03_A" texgens="1 0 0 1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-2 124 -7" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 124 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 20" />
                            <Vertex pos="4 4 -20" />
                            <Vertex pos="4 -4 20" />
                            <Vertex pos="4 -4 -20" />
                            <Vertex pos="-4 4 20" />
                            <Vertex pos="-4 4 -20" />
                            <Vertex pos="-4 -4 20" />
                            <Vertex pos="-4 -4 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile03_A" texgens="1 0 0 1536 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-24 66 -7.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 66 0 0 1 -7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19.25" />
                            <Vertex pos="2 2 -19.25" />
                            <Vertex pos="2 -2 19.25" />
                            <Vertex pos="2 -2 -19.25" />
                            <Vertex pos="-2 2 19.25" />
                            <Vertex pos="-2 2 -19.25" />
                            <Vertex pos="-2 -2 19.25" />
                            <Vertex pos="-2 -2 -19.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.25" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-26 62 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 62 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 18.75" />
                            <Vertex pos="4 2 -18.75" />
                            <Vertex pos="4 -2 18.75" />
                            <Vertex pos="4 -2 -18.75" />
                            <Vertex pos="-4 2 18.75" />
                            <Vertex pos="-4 2 -18.75" />
                            <Vertex pos="-4 -2 18.75" />
                            <Vertex pos="-4 -2 -18.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18.75" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-30 66 -8.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 66 0 0 1 -8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 18.25" />
                            <Vertex pos="4 2 -18.25" />
                            <Vertex pos="4 -2 18.25" />
                            <Vertex pos="4 -2 -18.25" />
                            <Vertex pos="-4 2 18.25" />
                            <Vertex pos="-4 2 -18.25" />
                            <Vertex pos="-4 -2 18.25" />
                            <Vertex pos="-4 -2 -18.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1248 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1248 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1248 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1248 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18.25" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-36 68 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 68 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17.75" />
                            <Vertex pos="2 4 -17.75" />
                            <Vertex pos="2 -4 17.75" />
                            <Vertex pos="2 -4 -17.75" />
                            <Vertex pos="-2 4 17.75" />
                            <Vertex pos="-2 4 -17.75" />
                            <Vertex pos="-2 -4 17.75" />
                            <Vertex pos="-2 -4 -17.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17.75" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-32 72 -9.75" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 72 0 0 1 -9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17.25" />
                            <Vertex pos="2 4 -17.25" />
                            <Vertex pos="2 -4 17.25" />
                            <Vertex pos="2 -4 -17.25" />
                            <Vertex pos="-2 4 17.25" />
                            <Vertex pos="-2 4 -17.25" />
                            <Vertex pos="-2 -4 17.25" />
                            <Vertex pos="-2 -4 -17.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17.25" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-2 132 -7" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 132 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 20" />
                            <Vertex pos="4 4 -20" />
                            <Vertex pos="4 -4 20" />
                            <Vertex pos="4 -4 -20" />
                            <Vertex pos="-4 4 20" />
                            <Vertex pos="-4 4 -20" />
                            <Vertex pos="-4 -4 20" />
                            <Vertex pos="-4 -4 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile03_A" texgens="1 0 0 1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-14 132 -7" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 132 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 20" />
                            <Vertex pos="4 4 -20" />
                            <Vertex pos="4 -4 20" />
                            <Vertex pos="4 -4 -20" />
                            <Vertex pos="-4 4 20" />
                            <Vertex pos="-4 4 -20" />
                            <Vertex pos="-4 -4 20" />
                            <Vertex pos="-4 -4 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile03_A" texgens="1 0 0 1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-8 132 -7" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 132 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 20" />
                            <Vertex pos="2 4 -20" />
                            <Vertex pos="2 -4 20" />
                            <Vertex pos="2 -4 -20" />
                            <Vertex pos="-2 4 20" />
                            <Vertex pos="-2 4 -20" />
                            <Vertex pos="-2 -4 20" />
                            <Vertex pos="-2 -4 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1792 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile03_A" texgens="1 0 0 2048 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="-36 76 -11" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 76 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 16" />
                            <Vertex pos="2 4 -16" />
                            <Vertex pos="2 -4 16" />
                            <Vertex pos="2 -4 -16" />
                            <Vertex pos="-2 4 16" />
                            <Vertex pos="-2 4 -16" />
                            <Vertex pos="-2 -4 16" />
                            <Vertex pos="-2 -4 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="-32 80 -11" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 80 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 16" />
                            <Vertex pos="2 4 -16" />
                            <Vertex pos="2 -4 16" />
                            <Vertex pos="2 -4 -16" />
                            <Vertex pos="-2 4 16" />
                            <Vertex pos="-2 4 -16" />
                            <Vertex pos="-2 -4 16" />
                            <Vertex pos="-2 -4 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="-36 82 -11" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 82 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16" />
                            <Vertex pos="2 2 -16" />
                            <Vertex pos="2 -2 16" />
                            <Vertex pos="2 -2 -16" />
                            <Vertex pos="-2 2 16" />
                            <Vertex pos="-2 2 -16" />
                            <Vertex pos="-2 -2 16" />
                            <Vertex pos="-2 -2 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="-34 96 -12" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 96 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 15" />
                            <Vertex pos="4 4 -15" />
                            <Vertex pos="4 -4 15" />
                            <Vertex pos="4 -4 -15" />
                            <Vertex pos="-4 4 15" />
                            <Vertex pos="-4 4 -15" />
                            <Vertex pos="-4 -4 15" />
                            <Vertex pos="-4 -4 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="-34 106 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 106 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 17.75" />
                            <Vertex pos="4 2 -17.75" />
                            <Vertex pos="4 -2 17.75" />
                            <Vertex pos="4 -2 -17.75" />
                            <Vertex pos="-4 2 17.75" />
                            <Vertex pos="-4 2 -17.75" />
                            <Vertex pos="-4 -2 17.75" />
                            <Vertex pos="-4 -2 -17.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17.75" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="-36 110 -9.75" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 110 0 0 1 -9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17.25" />
                            <Vertex pos="2 2 -17.25" />
                            <Vertex pos="2 -2 17.25" />
                            <Vertex pos="2 -2 -17.25" />
                            <Vertex pos="-2 2 17.25" />
                            <Vertex pos="-2 2 -17.25" />
                            <Vertex pos="-2 -2 17.25" />
                            <Vertex pos="-2 -2 -17.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="-32 110 -10.25" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 110 0 0 1 -10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16.75" />
                            <Vertex pos="2 2 -16.75" />
                            <Vertex pos="2 -2 16.75" />
                            <Vertex pos="2 -2 -16.75" />
                            <Vertex pos="-2 2 16.75" />
                            <Vertex pos="-2 2 -16.75" />
                            <Vertex pos="-2 -2 16.75" />
                            <Vertex pos="-2 -2 -16.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.75" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="-36 116 -11" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 116 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 16" />
                            <Vertex pos="2 4 -16" />
                            <Vertex pos="2 -4 16" />
                            <Vertex pos="2 -4 -16" />
                            <Vertex pos="-2 4 16" />
                            <Vertex pos="-2 4 -16" />
                            <Vertex pos="-2 -4 16" />
                            <Vertex pos="-2 -4 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-32 118 -11.25" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 118 0 0 1 -11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15.75" />
                            <Vertex pos="2 2 -15.75" />
                            <Vertex pos="2 -2 15.75" />
                            <Vertex pos="2 -2 -15.75" />
                            <Vertex pos="-2 2 15.75" />
                            <Vertex pos="-2 2 -15.75" />
                            <Vertex pos="-2 -2 15.75" />
                            <Vertex pos="-2 -2 -15.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15.75" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-32 114 -12" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 114 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15" />
                            <Vertex pos="2 2 -15" />
                            <Vertex pos="2 -2 15" />
                            <Vertex pos="2 -2 -15" />
                            <Vertex pos="-2 2 15" />
                            <Vertex pos="-2 2 -15" />
                            <Vertex pos="-2 -2 15" />
                            <Vertex pos="-2 -2 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_physics_repulsion" texgens="1 0 0 -8192 0 -1 0 -29184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-30 122 -10.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 122 0 0 1 -10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 16.25" />
                            <Vertex pos="4 2 -16.25" />
                            <Vertex pos="4 -2 16.25" />
                            <Vertex pos="4 -2 -16.25" />
                            <Vertex pos="-4 2 16.25" />
                            <Vertex pos="-4 2 -16.25" />
                            <Vertex pos="-4 -2 16.25" />
                            <Vertex pos="-4 -2 -16.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.25" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-28 118 -10.75" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 118 0 0 1 -10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16.25" />
                            <Vertex pos="2 2 -16.25" />
                            <Vertex pos="2 -2 16.25" />
                            <Vertex pos="2 -2 -16.25" />
                            <Vertex pos="-2 2 16.25" />
                            <Vertex pos="-2 2 -16.25" />
                            <Vertex pos="-2 -2 16.25" />
                            <Vertex pos="-2 -2 -16.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -30208 0 0 -1 2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-15 67 11" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 67 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 2" />
                            <Vertex pos="3 1 -2" />
                            <Vertex pos="3 -1 2" />
                            <Vertex pos="3 -1 -2" />
                            <Vertex pos="-3 1 2" />
                            <Vertex pos="-3 1 -2" />
                            <Vertex pos="-3 -1 2" />
                            <Vertex pos="-3 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1152 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 1408 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1152 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-14 61 11" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 61 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 2" />
                            <Vertex pos="4 1 -2" />
                            <Vertex pos="4 -1 2" />
                            <Vertex pos="4 -1 -2" />
                            <Vertex pos="-4 1 2" />
                            <Vertex pos="-4 1 -2" />
                            <Vertex pos="-4 -1 2" />
                            <Vertex pos="-4 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 1536 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-17 64 11" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 64 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile03_A" texgens="1 0 0 768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-11 65 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 65 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 1.75" />
                            <Vertex pos="1 3 -1.75" />
                            <Vertex pos="1 -3 1.75" />
                            <Vertex pos="1 -3 -1.75" />
                            <Vertex pos="-1 3 1.75" />
                            <Vertex pos="-1 3 -1.75" />
                            <Vertex pos="-1 -3 1.75" />
                            <Vertex pos="-1 -3 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_tile03_A" texgens="1 0 0 768 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-24 126 -10" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 126 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17" />
                            <Vertex pos="2 2 -17" />
                            <Vertex pos="2 -2 17" />
                            <Vertex pos="2 -2 -17" />
                            <Vertex pos="-2 2 17" />
                            <Vertex pos="-2 2 -17" />
                            <Vertex pos="-2 -2 17" />
                            <Vertex pos="-2 -2 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -32256 0 0 -1 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-22 132 -10" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 132 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-28 130 -10" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 130 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17" />
                            <Vertex pos="2 2 -17" />
                            <Vertex pos="2 -2 17" />
                            <Vertex pos="2 -2 -17" />
                            <Vertex pos="-2 2 17" />
                            <Vertex pos="-2 2 -17" />
                            <Vertex pos="-2 -2 17" />
                            <Vertex pos="-2 -2 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -7168 0 0 -1 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="-28 126 -10.25" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 126 0 0 1 -10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16.75" />
                            <Vertex pos="2 2 -16.75" />
                            <Vertex pos="2 -2 16.75" />
                            <Vertex pos="2 -2 -16.75" />
                            <Vertex pos="-2 2 16.75" />
                            <Vertex pos="-2 2 -16.75" />
                            <Vertex pos="-2 -2 16.75" />
                            <Vertex pos="-2 -2 -16.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -7168 0 0 -1 2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.75" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-27 28 -15" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 28 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 12" />
                            <Vertex pos="1 4 -12" />
                            <Vertex pos="1 -4 12" />
                            <Vertex pos="1 -4 -12" />
                            <Vertex pos="-1 4 12" />
                            <Vertex pos="-1 4 -12" />
                            <Vertex pos="-1 -4 12" />
                            <Vertex pos="-1 -4 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 896 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile03_A" texgens="1 0 0 256 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-32 28 -15" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 28 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 12" />
                            <Vertex pos="4 4 -12" />
                            <Vertex pos="4 -4 12" />
                            <Vertex pos="4 -4 -12" />
                            <Vertex pos="-4 4 12" />
                            <Vertex pos="-4 4 -12" />
                            <Vertex pos="-4 -4 12" />
                            <Vertex pos="-4 -4 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-32 33 -15" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 33 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 12" />
                            <Vertex pos="4 1 -12" />
                            <Vertex pos="4 -1 12" />
                            <Vertex pos="4 -1 -12" />
                            <Vertex pos="-4 1 12" />
                            <Vertex pos="-4 1 -12" />
                            <Vertex pos="-4 -1 12" />
                            <Vertex pos="-4 -1 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-5 28 -13" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 28 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 14" />
                            <Vertex pos="1 4 -14" />
                            <Vertex pos="1 -4 14" />
                            <Vertex pos="1 -4 -14" />
                            <Vertex pos="-1 4 14" />
                            <Vertex pos="-1 4 -14" />
                            <Vertex pos="-1 -4 14" />
                            <Vertex pos="-1 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 896 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 256 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-6 62 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 62 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 19.75" />
                            <Vertex pos="4 2 -19.75" />
                            <Vertex pos="4 -2 19.75" />
                            <Vertex pos="4 -2 -19.75" />
                            <Vertex pos="-4 2 19.75" />
                            <Vertex pos="-4 2 -19.75" />
                            <Vertex pos="-4 -2 19.75" />
                            <Vertex pos="-4 -2 -19.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.75" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-8 66 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 66 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19.5" />
                            <Vertex pos="2 2 -19.5" />
                            <Vertex pos="2 -2 19.5" />
                            <Vertex pos="2 -2 -19.5" />
                            <Vertex pos="-2 2 19.5" />
                            <Vertex pos="-2 2 -19.5" />
                            <Vertex pos="-2 -2 19.5" />
                            <Vertex pos="-2 -2 -19.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.5" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-16 142 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 142 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19.5" />
                            <Vertex pos="2 2 -19.5" />
                            <Vertex pos="2 -2 19.5" />
                            <Vertex pos="2 -2 -19.5" />
                            <Vertex pos="-2 2 19.5" />
                            <Vertex pos="-2 2 -19.5" />
                            <Vertex pos="-2 -2 19.5" />
                            <Vertex pos="-2 -2 -19.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.5" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-16 146 -8" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 146 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19" />
                            <Vertex pos="2 2 -19" />
                            <Vertex pos="2 -2 19" />
                            <Vertex pos="2 -2 -19" />
                            <Vertex pos="-2 2 19" />
                            <Vertex pos="-2 2 -19" />
                            <Vertex pos="-2 -2 19" />
                            <Vertex pos="-2 -2 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-16 151 -9" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 151 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 18" />
                            <Vertex pos="2 3 -18" />
                            <Vertex pos="2 -3 18" />
                            <Vertex pos="2 -3 -18" />
                            <Vertex pos="-2 3 18" />
                            <Vertex pos="-2 3 -18" />
                            <Vertex pos="-2 -3 18" />
                            <Vertex pos="-2 -3 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_physics_repulsion" texgens="1 0 0 -4096 0 -1 0 -38656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-16 156 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 156 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 18.75" />
                            <Vertex pos="2 2 -18.75" />
                            <Vertex pos="2 -2 18.75" />
                            <Vertex pos="2 -2 -18.75" />
                            <Vertex pos="-2 2 18.75" />
                            <Vertex pos="-2 2 -18.75" />
                            <Vertex pos="-2 -2 18.75" />
                            <Vertex pos="-2 -2 -18.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18.75" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-16 161 -9" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 161 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 18" />
                            <Vertex pos="2 3 -18" />
                            <Vertex pos="2 -3 18" />
                            <Vertex pos="2 -3 -18" />
                            <Vertex pos="-2 3 18" />
                            <Vertex pos="-2 3 -18" />
                            <Vertex pos="-2 -3 18" />
                            <Vertex pos="-2 -3 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_physics_repulsion" texgens="1 0 0 -4096 0 -1 0 -41216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="-16 166 -8" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 166 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19" />
                            <Vertex pos="2 2 -19" />
                            <Vertex pos="2 -2 19" />
                            <Vertex pos="2 -2 -19" />
                            <Vertex pos="-2 2 19" />
                            <Vertex pos="-2 2 -19" />
                            <Vertex pos="-2 -2 19" />
                            <Vertex pos="-2 -2 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="-16 170 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 170 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19.5" />
                            <Vertex pos="2 2 -19.5" />
                            <Vertex pos="2 -2 19.5" />
                            <Vertex pos="2 -2 -19.5" />
                            <Vertex pos="-2 2 19.5" />
                            <Vertex pos="-2 2 -19.5" />
                            <Vertex pos="-2 -2 19.5" />
                            <Vertex pos="-2 -2 -19.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.5" album="" material="bm_tile03_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-14 178 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 178 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 19.75" />
                            <Vertex pos="4 6 -19.75" />
                            <Vertex pos="4 -6 19.75" />
                            <Vertex pos="4 -6 -19.75" />
                            <Vertex pos="-4 6 19.75" />
                            <Vertex pos="-4 6 -19.75" />
                            <Vertex pos="-4 -6 19.75" />
                            <Vertex pos="-4 -6 -19.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.75" album="" material="bm_tile03_A" texgens="1 0 0 1536 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="0 -4.25 1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -4.25 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 3.57628e-007" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 3.57628e-007" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4.5 -0.25 0.5" />
                            <Vertex pos="-4.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="0 -4.75 1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -4.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="5 -0.25 0.5" />
                            <Vertex pos="5 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-5 -0.25 0.5" />
                            <Vertex pos="-5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -3.35876" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.35876" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="9.875 64 6.75" rot="1 0 0 0" scale="" transform="1 0 0 9.875 0 1 0 64 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 16384 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -16384 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_trim" texgens="-1 0 0 -2528 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_trim" texgens="1 0 0 2528 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 2528 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -2528 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="-4.25 -0.25 1" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 -0.25 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 1.19209e-007" />
                            <Vertex pos="0.25 4.25 -0.5" />
                            <Vertex pos="0.25 -3.75 1.19209e-007" />
                            <Vertex pos="0.25 -3.75 -0.5" />
                            <Vertex pos="-0.25 4.25 0.5" />
                            <Vertex pos="-0.25 4.25 -0.5" />
                            <Vertex pos="-0.25 -4.25 0.5" />
                            <Vertex pos="-0.25 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -832 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="-4.75 -0.5 1" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 -0.5 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.5 0.5" />
                            <Vertex pos="0.25 4.5 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4.5 0.5" />
                            <Vertex pos="-0.25 4.5 -0.5" />
                            <Vertex pos="-0.25 -4.5 0.5" />
                            <Vertex pos="-0.25 -4.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="4.75 -0.5 1" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 -0.5 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.5 0.5" />
                            <Vertex pos="0.25 4.5 -0.5" />
                            <Vertex pos="0.25 -4.5 0.5" />
                            <Vertex pos="0.25 -4.5 -0.5" />
                            <Vertex pos="-0.25 4.5 0.5" />
                            <Vertex pos="-0.25 4.5 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.0052" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="4.25 -0.25 1" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 -0.25 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.5" />
                            <Vertex pos="0.25 4.25 -0.5" />
                            <Vertex pos="0.25 -4.25 0.5" />
                            <Vertex pos="0.25 -4.25 -0.5" />
                            <Vertex pos="-0.25 4.25 1.19209e-007" />
                            <Vertex pos="-0.25 4.25 -0.5" />
                            <Vertex pos="-0.25 -3.75 1.19209e-007" />
                            <Vertex pos="-0.25 -3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -832 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.82843" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="4.75 6 1.5" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 6 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="4.25 6 1.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 6 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="4.75 9 2" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 9 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -1 0.5" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 0.5" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -1 0.5" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="4.25 9 2" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 9 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -1 0.5" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 2.38419e-007" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -1 2.38419e-007" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="4.75 12 2.5" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 12 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="4.25 12 2.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 12 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 2.38419e-007" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 2.38419e-007" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="4.75 15 2" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -1 0.5" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 0.5" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -1 0.5" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="4.25 15 2" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -0.999999 0.5" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 2.38419e-007" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -0.999999 2.38419e-007" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-2.02656e-006 -1 2.02656e-006 -0.999999" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="4.75 18 1.5" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 18 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="4.25 18 1.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 18 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="5 28 -13" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 28 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 14" />
                            <Vertex pos="1 4 -14" />
                            <Vertex pos="1 -4 14" />
                            <Vertex pos="1 -4 -14" />
                            <Vertex pos="-1 4 14" />
                            <Vertex pos="-1 4 -14" />
                            <Vertex pos="-1 -4 14" />
                            <Vertex pos="-1 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 7168 0 0 -1 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 896 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_A" texgens="1 0 0 256 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="4.75 21.75 1" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 21.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.25 0.5" />
                            <Vertex pos="0.25 1.25 -0.5" />
                            <Vertex pos="0.25 -1.75 0.5" />
                            <Vertex pos="0.25 -1.75 -0.5" />
                            <Vertex pos="-0.25 1.75 0.5" />
                            <Vertex pos="-0.25 1.75 -0.5" />
                            <Vertex pos="-0.25 -1.75 0.5" />
                            <Vertex pos="-0.25 -1.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.06066" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="4.25 22 1" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 22 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.5" />
                            <Vertex pos="0.25 1.5 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 1.19209e-007" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 1.19209e-007" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.23744" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="0 32.25 0.999991" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 32.25 0 0 1 0.999991 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.499991" />
                            <Vertex pos="6 0.25 -0.499991" />
                            <Vertex pos="6 -0.25 5.96046e-007" />
                            <Vertex pos="6 -0.25 -0.499991" />
                            <Vertex pos="-6 0.25 0.499991" />
                            <Vertex pos="-6 0.25 -0.499991" />
                            <Vertex pos="-6 -0.25 5.96046e-007" />
                            <Vertex pos="-6 -0.25 -0.499991" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0.00195313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0.00195313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 0 -1 0.00195313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 0 -1 0.00195313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.7071 0.707114 -0.176775" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499991" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="0 32.75 1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 32.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.5" />
                            <Vertex pos="6 0.25 -0.5" />
                            <Vertex pos="6 -0.25 0.5" />
                            <Vertex pos="6 -0.25 -0.5" />
                            <Vertex pos="-6 0.25 0.5" />
                            <Vertex pos="-6 0.25 -0.5" />
                            <Vertex pos="-6 -0.25 0.5" />
                            <Vertex pos="-6 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="8 32.25 0.500002" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 32.25 0 0 1 0.500002 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.500002" />
                            <Vertex pos="2 0.25 -0.500002" />
                            <Vertex pos="2 -0.25 1.37091e-006" />
                            <Vertex pos="2 -0.25 -0.500002" />
                            <Vertex pos="-2 0.25 0.500002" />
                            <Vertex pos="-2 0.25 -0.500002" />
                            <Vertex pos="-2 -0.25 1.37091e-006" />
                            <Vertex pos="-2 -0.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -0.000488281 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -0.000488281 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 -0.000488281 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 -0.000488281 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="8 32.75 0.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 32.75 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="14 32.25 5.99027e-006" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 32.25 0 0 1 5.99027e-006 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.500006" />
                            <Vertex pos="4 0.25 -0.500006" />
                            <Vertex pos="4 -0.25 4.79934e-006" />
                            <Vertex pos="4 -0.25 -0.500006" />
                            <Vertex pos="-4 0.25 0.500006" />
                            <Vertex pos="-4 0.25 -0.500006" />
                            <Vertex pos="-4 -0.25 4.79934e-006" />
                            <Vertex pos="-4 -0.25 -0.500006" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -0.00153351 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -0.00153351 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 -0.00153351 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 -0.00153351 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707108 0.707106 -0.17678" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500006" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="14 32.75 0" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 32.75 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.5" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 0.5" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="5 23.75 1" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 23.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 2.38419e-007" />
                            <Vertex pos="1 0.25 -0.500001" />
                            <Vertex pos="1 -0.25 0.500001" />
                            <Vertex pos="1 -0.25 -0.500001" />
                            <Vertex pos="-1 0.25 2.38419e-007" />
                            <Vertex pos="-1 0.25 -0.500001" />
                            <Vertex pos="-0.5 -0.25 0.500001" />
                            <Vertex pos="-0.5 -0.25 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="5.25 23.25 1" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 23.25 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.750001 0.25 0.5" />
                            <Vertex pos="0.750001 0.25 -0.5" />
                            <Vertex pos="0.750001 -0.25 0.5" />
                            <Vertex pos="0.750001 -0.25 -0.5" />
                            <Vertex pos="-0.75 0.25 0.5" />
                            <Vertex pos="-0.75 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.750001" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.353553" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="10 23.75 0.499994" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 23.75 0 0 1 0.499994 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.250002 -1.21295e-005" />
                            <Vertex pos="4 0.25 -0.499994" />
                            <Vertex pos="4 -0.25 0.499994" />
                            <Vertex pos="4 -0.25 -0.499994" />
                            <Vertex pos="-4 0.250002 -1.21295e-005" />
                            <Vertex pos="-4 0.25 -0.499994" />
                            <Vertex pos="-4 -0.25 0.499994" />
                            <Vertex pos="-4 -0.25 -0.499994" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0.00146484 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0.00146484 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -3.99366e-006 -0.250002" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 0.00146484 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 0.00146484 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.70711 0.707104 -0.17677" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499994" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="10 23.25 0.5" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 23.25 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.5" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 0.5" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="18.25 23.75 -4.08292e-006" rot="1 0 0 0" scale="" transform="1 0 0 18.25 0 1 0 23.75 0 0 1 -4.08292e-006 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.75 0.250002 -4.00927e-006" />
                            <Vertex pos="3.75 0.25 -0.499996" />
                            <Vertex pos="4.25 -0.250002 0.499996" />
                            <Vertex pos="4.25 -0.25 -0.499996" />
                            <Vertex pos="-4.25 0.250002 -4.00927e-006" />
                            <Vertex pos="-4.25 0.25 -0.499996" />
                            <Vertex pos="-4.25 -0.250002 0.499996" />
                            <Vertex pos="-4.25 -0.25 -0.499996" />
                        </Vertices>
                        <Face id="0" plane="0.707109 0.707105 1.41193e-006 -2.82844" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0.00104523 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0.00104523 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -3.99358e-006 -0.250002" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 0.00104523 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -1.99677e-006 -0.250001" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 0.00104523 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707104 0.70711 -0.176775" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499996" album="" material="bm_edge_white" texgens="-1 0 0 1216 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="18.5 23.25 0" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 23.25 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.5" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-4.5 -0.25 0.5" />
                            <Vertex pos="-4.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="22.75 25.5 0" rot="1 0 0 0" scale="" transform="1 0 0 22.75 0 1 0 25.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.5" />
                            <Vertex pos="0.25 2.5 -0.5" />
                            <Vertex pos="0.25 -2.5 0.5" />
                            <Vertex pos="0.25 -2.5 -0.5" />
                            <Vertex pos="-0.25 2.5 0.5" />
                            <Vertex pos="-0.25 2.5 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.59099" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="22.25 25.75 1.72853e-006" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 25.75 0 0 1 1.72853e-006 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.500002" />
                            <Vertex pos="0.25 2.25 -0.500002" />
                            <Vertex pos="0.25 -2.25 0.500001" />
                            <Vertex pos="0.25 -2.25 -0.500002" />
                            <Vertex pos="-0.25 2.25 2.94517e-007" />
                            <Vertex pos="-0.25 2.25 -0.500002" />
                            <Vertex pos="-0.25 -1.75 -7.74859e-007" />
                            <Vertex pos="-0.25 -1.75 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -0.000442505 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -0.000442505 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 -0.000442505 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 -0.000442505 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707108 -1.8904e-007 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="24.25 27.75 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 24.25 0 1 0 27.75 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.250002 -4.76837e-007" />
                            <Vertex pos="1.75 0.25 -0.5" />
                            <Vertex pos="2.25 -0.25 0.5" />
                            <Vertex pos="2.25 -0.25 -0.5" />
                            <Vertex pos="-2.25 0.250002 -4.76837e-007" />
                            <Vertex pos="-2.25 0.25 -0.5" />
                            <Vertex pos="-2.25 -0.25 0.5" />
                            <Vertex pos="-2.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707108 0.707105 0 -1.41422" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -3.99351e-006 -0.250002" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707106 0.707108 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="24.5 27.25 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 24.5 0 1 0 27.25 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2.5 -0.25 0.5" />
                            <Vertex pos="2.5 -0.25 -0.5" />
                            <Vertex pos="-2.5 0.25 0.5" />
                            <Vertex pos="-2.5 0.25 -0.5" />
                            <Vertex pos="-2.5 -0.25 0.5" />
                            <Vertex pos="-2.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="26.75 33.5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 26.75 0 1 0 33.5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.5 0.5" />
                            <Vertex pos="0.25 6.5 -0.5" />
                            <Vertex pos="0.25 -6.5 0.5" />
                            <Vertex pos="0.25 -6.5 -0.5" />
                            <Vertex pos="-0.25 6.5 0.5" />
                            <Vertex pos="-0.25 6.5 -0.5" />
                            <Vertex pos="-0.25 -6 0.5" />
                            <Vertex pos="-0.25 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.41942" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="26.25 33.75 -0.500001" rot="1 0 0 0" scale="" transform="1 0 0 26.25 0 1 0 33.75 0 0 1 -0.500001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.25001 0.499998" />
                            <Vertex pos="0.25 6.25001 -0.499999" />
                            <Vertex pos="0.25 -6.25 0.499999" />
                            <Vertex pos="0.25 -6.25 -0.499999" />
                            <Vertex pos="-0.25 6.25001 -2.38419e-006" />
                            <Vertex pos="-0.25 6.25001 -0.499999" />
                            <Vertex pos="-0.25 -5.75 -1.19209e-006" />
                            <Vertex pos="-0.25 -5.75 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1344 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.25001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.24264" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 7.02451e-008 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="17.75 34 -0.500004" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 34 0 0 1 -0.500004 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -3.8743e-006" />
                            <Vertex pos="0.25 2 -0.499996" />
                            <Vertex pos="0.25 -2 -3.8743e-006" />
                            <Vertex pos="0.25 -2 -0.499996" />
                            <Vertex pos="-0.25 2 0.499996" />
                            <Vertex pos="-0.25 2 -0.499996" />
                            <Vertex pos="-0.25 -2 0.499996" />
                            <Vertex pos="-0.25 -2 -0.499996" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176774" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499996" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="17.25 34 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 17.25 0 1 0 34 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="17.75 42 1.75834e-006" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 42 0 0 1 1.75834e-006 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 5.82806e-006" />
                            <Vertex pos="0.25 6 -0.500002" />
                            <Vertex pos="0.25 -6 5.82806e-006" />
                            <Vertex pos="0.25 -6 -0.500002" />
                            <Vertex pos="-0.25 6 0.500002" />
                            <Vertex pos="-0.25 6 -0.500002" />
                            <Vertex pos="-0.25 -6 0.500002" />
                            <Vertex pos="-0.25 -6 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 -0.000450134 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 -0.000450134 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 -0.000450134 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 -0.000450134 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707104 0 0.70711 -0.17678" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="17.25 42 0" rot="1 0 0 0" scale="" transform="1 0 0 17.25 0 1 0 42 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.5" />
                            <Vertex pos="0.25 6 -0.5" />
                            <Vertex pos="0.25 -6 0.5" />
                            <Vertex pos="0.25 -6 -0.5" />
                            <Vertex pos="-0.25 6 0.5" />
                            <Vertex pos="-0.25 6 -0.5" />
                            <Vertex pos="-0.25 -6 0.5" />
                            <Vertex pos="-0.25 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="17.75 52 2" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 52 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="17.25 52 2" rot="1 0 0 0" scale="" transform="1 0 0 17.25 0 1 0 52 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="17.75 58 1" rot="1 0 0 0" scale="" transform="1 0 0 17.75 0 1 0 58 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.19209e-007" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 1.19209e-007" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="17.25 58 1" rot="1 0 0 0" scale="" transform="1 0 0 17.25 0 1 0 58 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="26.75 42 0.5" rot="1 0 0 0" scale="" transform="1 0 0 26.75 0 1 0 42 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="26.25 42 0.500001" rot="1 0 0 0" scale="" transform="1 0 0 26.25 0 1 0 42 0 0 1 0.500001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.500001" />
                            <Vertex pos="0.25 2 -0.500001" />
                            <Vertex pos="0.25 -2 0.500001" />
                            <Vertex pos="0.25 -2 -0.500001" />
                            <Vertex pos="-0.25 2 5.96046e-007" />
                            <Vertex pos="-0.25 2 -0.500001" />
                            <Vertex pos="-0.25 -2 5.96046e-007" />
                            <Vertex pos="-0.25 -2 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="26.75 46 1.5" rot="1 0 0 0" scale="" transform="1 0 0 26.75 0 1 0 46 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="26.25 46 1.50001" rot="1 0 0 0" scale="" transform="1 0 0 26.25 0 1 0 46 0 0 1 1.50001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.500007" />
                            <Vertex pos="0.25 2 -0.500007" />
                            <Vertex pos="0.25 -2 0.500007" />
                            <Vertex pos="0.25 -2 -0.500007" />
                            <Vertex pos="-0.25 2 6.91414e-006" />
                            <Vertex pos="-0.25 2 -0.500007" />
                            <Vertex pos="-0.25 -2 6.91414e-006" />
                            <Vertex pos="-0.25 -2 -0.500007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 -0.00195313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 -0.00195313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 -0.00195313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 -0.00195313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176782" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500007" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="26.75 50 2" rot="1 0 0 0" scale="" transform="1 0 0 26.75 0 1 0 50 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="26.25 50 2" rot="1 0 0 0" scale="" transform="1 0 0 26.25 0 1 0 50 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.500001" />
                            <Vertex pos="0.25 2 -0.500001" />
                            <Vertex pos="0.25 -2 0.500001" />
                            <Vertex pos="0.25 -2 -0.500001" />
                            <Vertex pos="-0.25 2 1.19209e-006" />
                            <Vertex pos="-0.25 2 -0.500001" />
                            <Vertex pos="-0.25 -2 1.19209e-006" />
                            <Vertex pos="-0.25 -2 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="26.75 54 2.5" rot="1 0 0 0" scale="" transform="1 0 0 26.75 0 1 0 54 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="26.25 54 2.5" rot="1 0 0 0" scale="" transform="1 0 0 26.25 0 1 0 54 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.500002" />
                            <Vertex pos="0.25 2 -0.500001" />
                            <Vertex pos="0.25 -2 0.500002" />
                            <Vertex pos="0.25 -2 -0.500001" />
                            <Vertex pos="-0.25 2 1.66893e-006" />
                            <Vertex pos="-0.25 2 -0.500001" />
                            <Vertex pos="-0.25 -2 1.66893e-006" />
                            <Vertex pos="-0.25 -2 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="28.25 55.75 3.5" rot="1 0 0 0" scale="" transform="1 0 0 28.25 0 1 0 55.75 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.250004 -1.19209e-006" />
                            <Vertex pos="1.75 0.25 -0.499999" />
                            <Vertex pos="2.25 -0.249996 0.499999" />
                            <Vertex pos="2.25 -0.25 -0.499999" />
                            <Vertex pos="-2.25 0.250004 -1.19209e-006" />
                            <Vertex pos="-2.25 0.25 -0.499999" />
                            <Vertex pos="-2.25 -0.249996 0.499999" />
                            <Vertex pos="-2.25 -0.25 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="0.707108 0.707105 -2.82384e-006 -1.41422" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -7.98706e-006 -0.250004" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 3.99352e-006 -0.249998" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="28.5 55.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 28.5 0 1 0 55.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.99999 0.25 0.5" />
                            <Vertex pos="1.99999 0.25 -0.5" />
                            <Vertex pos="2.49999 -0.25 0.5" />
                            <Vertex pos="2.49999 -0.25 -0.5" />
                            <Vertex pos="-2.5 0.25 0.5" />
                            <Vertex pos="-2.5 0.25 -0.5" />
                            <Vertex pos="-2.5 -0.25 0.5" />
                            <Vertex pos="-2.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.59098" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="30.75 60 3.5" rot="1 0 0 0" scale="" transform="1 0 0 30.75 0 1 0 60 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5 0.5" />
                            <Vertex pos="0.25 5 -0.5" />
                            <Vertex pos="0.25 -5 0.5" />
                            <Vertex pos="0.25 -5 -0.5" />
                            <Vertex pos="-0.25 4.5 0.5" />
                            <Vertex pos="-0.25 4.5 -0.5" />
                            <Vertex pos="-0.25 -4.5 0.5" />
                            <Vertex pos="-0.25 -4.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -3.35876" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.35876" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="30.25 60 3.5" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 60 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.5 0.500002" />
                            <Vertex pos="0.25 4.5 -0.500002" />
                            <Vertex pos="0.25 -4.5 0.500002" />
                            <Vertex pos="0.25 -4.5 -0.500002" />
                            <Vertex pos="-0.25 4 1.43051e-006" />
                            <Vertex pos="-0.25 4 -0.500002" />
                            <Vertex pos="-0.25 -4 1.43051e-006" />
                            <Vertex pos="-0.25 -4 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.0052" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707106 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="29.25 64.25 3.49999" rot="1 0 0 0" scale="" transform="1 0 0 29.25 0 1 0 64.25 0 0 1 3.49999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.25 0.499994" />
                            <Vertex pos="1.25 0.25 -0.499994" />
                            <Vertex pos="0.75 -0.25 -6.4373e-006" />
                            <Vertex pos="0.75 -0.25 -0.499994" />
                            <Vertex pos="-1.25 0.25 0.499994" />
                            <Vertex pos="-1.25 0.25 -0.499994" />
                            <Vertex pos="-1.25 -0.25 -6.4373e-006" />
                            <Vertex pos="-1.25 -0.25 -0.499994" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.707107" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2752 0 0 -1 -0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2624 0 0 -1 -0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176772" album="" material="bm_edge_white" texgens="1 0 0 -2624 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499994" album="" material="bm_edge_white" texgens="-1 0 0 2752 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="29.5 64.75 3.5" rot="1 0 0 0" scale="" transform="1 0 0 29.5 0 1 0 64.75 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 0.5" />
                            <Vertex pos="1.5 0.25 -0.5" />
                            <Vertex pos="1 -0.25 0.5" />
                            <Vertex pos="1 -0.25 -0.5" />
                            <Vertex pos="-1.5 0.25 0.5" />
                            <Vertex pos="-1.5 0.25 -0.5" />
                            <Vertex pos="-1.5 -0.25 0.5" />
                            <Vertex pos="-1.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.883883" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="28.75 66.5 4.5" rot="1 0 0 0" scale="" transform="1 0 0 28.75 0 1 0 66.5 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.5" />
                            <Vertex pos="0.25 2.5 -0.5" />
                            <Vertex pos="0.25 -2.5 0.5" />
                            <Vertex pos="0.25 -2.5 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2.5 0.5" />
                            <Vertex pos="-0.25 -2.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="28.25 66.25 4.5" rot="1 0 0 0" scale="" transform="1 0 0 28.25 0 1 0 66.25 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.5" />
                            <Vertex pos="0.25 2.25 -0.5" />
                            <Vertex pos="0.25 -2.25 0.5" />
                            <Vertex pos="0.25 -2.25 -0.5" />
                            <Vertex pos="-0.25 1.75 4.76837e-007" />
                            <Vertex pos="-0.25 1.75 -0.5" />
                            <Vertex pos="-0.25 -2.25 0" />
                            <Vertex pos="-0.25 -2.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3648 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3520 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707106 -8.42937e-008 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="26.25 68.25 4.50002" rot="1 0 0 0" scale="" transform="1 0 0 26.25 0 1 0 68.25 0 0 1 4.50002 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.500021" />
                            <Vertex pos="2.25 0.25 -0.500022" />
                            <Vertex pos="1.75 -0.25 2.09808e-005" />
                            <Vertex pos="1.75 -0.25 -0.500022" />
                            <Vertex pos="-2.25 0.25 0.500021" />
                            <Vertex pos="-2.25 0.25 -0.500022" />
                            <Vertex pos="-2.25 -0.25 2.09808e-005" />
                            <Vertex pos="-2.25 -0.25 -0.500022" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2496 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2368 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176792" album="" material="bm_edge_white" texgens="1 0 0 -2368 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500022" album="" material="bm_edge_white" texgens="-1 0 0 2496 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="26.5 68.75 4.5" rot="1 0 0 0" scale="" transform="1 0 0 26.5 0 1 0 68.75 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.5" />
                            <Vertex pos="2.5 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2.5 0.25 0.5" />
                            <Vertex pos="-2.5 0.25 -0.5" />
                            <Vertex pos="-2.5 -0.25 0.5" />
                            <Vertex pos="-2.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2304 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="23 68.25 5" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 68.25 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.500003" />
                            <Vertex pos="1 0.25 -0.500003" />
                            <Vertex pos="1 -0.25 2.38419e-006" />
                            <Vertex pos="1 -0.25 -0.500003" />
                            <Vertex pos="-1 0.25 0.500003" />
                            <Vertex pos="-1 0.25 -0.500003" />
                            <Vertex pos="-1 -0.25 2.38419e-006" />
                            <Vertex pos="-1 -0.25 -0.500003" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500003" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="23 68.75 5" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 68.75 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.5" />
                            <Vertex pos="1 0.25 -0.5" />
                            <Vertex pos="1 -0.25 0.5" />
                            <Vertex pos="1 -0.25 -0.5" />
                            <Vertex pos="-1 0.25 0.5" />
                            <Vertex pos="-1 0.25 -0.5" />
                            <Vertex pos="-1 -0.25 0.5" />
                            <Vertex pos="-1 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="16 68.25 7" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 68.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.499999" />
                            <Vertex pos="6 0.25 -0.499998" />
                            <Vertex pos="6 -0.25 -1.90735e-006" />
                            <Vertex pos="6 -0.25 -0.499998" />
                            <Vertex pos="-6 0.25 0.499999" />
                            <Vertex pos="-6 0.25 -0.499998" />
                            <Vertex pos="-6 -0.25 -1.90735e-006" />
                            <Vertex pos="-6 -0.25 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -3456 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499998" album="" material="bm_edge_white" texgens="-1 0 0 3584 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="16 68.75 7" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 68.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.5" />
                            <Vertex pos="6 0.25 -0.5" />
                            <Vertex pos="6 -0.25 0.5" />
                            <Vertex pos="6 -0.25 -0.5" />
                            <Vertex pos="-6 0.25 0.5" />
                            <Vertex pos="-6 0.25 -0.5" />
                            <Vertex pos="-6 -0.25 0.5" />
                            <Vertex pos="-6 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3456 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3584 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="16 59.75 7.00001" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 59.75 0 0 1 7.00001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 5.72205e-006" />
                            <Vertex pos="6 0.25 -0.500007" />
                            <Vertex pos="6 -0.25 0.500006" />
                            <Vertex pos="6 -0.25 -0.500007" />
                            <Vertex pos="-6 0.25 5.72205e-006" />
                            <Vertex pos="-6 0.25 -0.500007" />
                            <Vertex pos="-6 -0.25 0.500006" />
                            <Vertex pos="-6 -0.25 -0.500007" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176781" album="" material="bm_edge_white" texgens="1 0 0 -2688 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500007" album="" material="bm_edge_white" texgens="-1 0 0 2816 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="16 59.25 7" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 59.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.5" />
                            <Vertex pos="6 0.25 -0.5" />
                            <Vertex pos="6 -0.25 0.5" />
                            <Vertex pos="6 -0.25 -0.5" />
                            <Vertex pos="-6 0.25 0.5" />
                            <Vertex pos="-6 0.25 -0.5" />
                            <Vertex pos="-6 -0.25 0.5" />
                            <Vertex pos="-6 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2688 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2816 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="4 68.25 11" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 68.25 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.500001" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.500001" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="4 68.75 11" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 68.75 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="4 59.75 11" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 59.75 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.500001" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.500001" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="4 59.25 11" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 59.25 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="0 59.75 11.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 59.75 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 9.53674e-007" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.500001" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 9.53674e-007" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.500001" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="0 59.25 11.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 59.25 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="-12 59.75 13" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 59.75 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 0.25 3.8147e-006" />
                            <Vertex pos="10 0.25 -0.500004" />
                            <Vertex pos="10 -0.25 0.500005" />
                            <Vertex pos="10 -0.25 -0.500004" />
                            <Vertex pos="-10 0.25 3.8147e-006" />
                            <Vertex pos="-10 0.25 -0.500004" />
                            <Vertex pos="-10 -0.25 0.500005" />
                            <Vertex pos="-10 -0.25 -0.500004" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3840 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3712 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707108 0.707106 -0.17678" album="" material="bm_edge_white" texgens="1 0 0 -3712 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500004" album="" material="bm_edge_white" texgens="-1 0 0 3840 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-12 59.25 13" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 59.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 0.25 0.5" />
                            <Vertex pos="10 0.25 -0.5" />
                            <Vertex pos="10 -0.25 0.5" />
                            <Vertex pos="10 -0.25 -0.5" />
                            <Vertex pos="-10 0.25 0.5" />
                            <Vertex pos="-10 0.25 -0.5" />
                            <Vertex pos="-10 -0.25 0.5" />
                            <Vertex pos="-10 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3840 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3712 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3712 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3840 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="0 68.25 12" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 68.25 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.500001" />
                            <Vertex pos="2 0.25 -0.500001" />
                            <Vertex pos="2 -0.25 0" />
                            <Vertex pos="2 -0.25 -0.500001" />
                            <Vertex pos="-2 0.25 0.500001" />
                            <Vertex pos="-2 0.25 -0.500001" />
                            <Vertex pos="-2 -0.25 0" />
                            <Vertex pos="-2 -0.25 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="0 68.75 12" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 68.75 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="-4 68.25 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 68.25 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.499999" />
                            <Vertex pos="2 0.25 -0.499998" />
                            <Vertex pos="2 -0.25 -1.90735e-006" />
                            <Vertex pos="2 -0.25 -0.499998" />
                            <Vertex pos="-2 0.25 0.499999" />
                            <Vertex pos="-2 0.25 -0.499998" />
                            <Vertex pos="-2 -0.25 -1.90735e-006" />
                            <Vertex pos="-2 -0.25 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499998" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="-4 68.75 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 68.75 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="-8 68.25 12" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 68.25 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.500001" />
                            <Vertex pos="2 0.25 -0.500001" />
                            <Vertex pos="2 -0.25 0" />
                            <Vertex pos="2 -0.25 -0.500001" />
                            <Vertex pos="-2 0.25 0.500001" />
                            <Vertex pos="-2 0.25 -0.500001" />
                            <Vertex pos="-2 -0.25 0" />
                            <Vertex pos="-2 -0.25 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-8 68.75 12" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 68.75 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="-16 68.25 13" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 68.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.499996" />
                            <Vertex pos="6 0.25 -0.499996" />
                            <Vertex pos="6 -0.25 -4.76837e-006" />
                            <Vertex pos="6 -0.25 -0.499996" />
                            <Vertex pos="-6 0.25 0.499996" />
                            <Vertex pos="-6 0.25 -0.499996" />
                            <Vertex pos="-6 -0.25 -4.76837e-006" />
                            <Vertex pos="-6 -0.25 -0.499996" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176773" album="" material="bm_edge_white" texgens="1 0 0 -3456 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499996" album="" material="bm_edge_white" texgens="-1 0 0 3584 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="-16 68.75 13" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 68.75 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.5" />
                            <Vertex pos="6 0.25 -0.5" />
                            <Vertex pos="6 -0.25 0.5" />
                            <Vertex pos="6 -0.25 -0.5" />
                            <Vertex pos="-6 0.25 0.5" />
                            <Vertex pos="-6 0.25 -0.5" />
                            <Vertex pos="-6 -0.25 0.5" />
                            <Vertex pos="-6 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3456 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3584 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="-26.25 59.75 11" rot="1 0 0 0" scale="" transform="1 0 0 -26.25 0 1 0 59.75 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.25 0" />
                            <Vertex pos="4.25 0.25 -0.5" />
                            <Vertex pos="4.25 -0.25 0.500001" />
                            <Vertex pos="4.25 -0.25 -0.5" />
                            <Vertex pos="-3.75 0.25 0" />
                            <Vertex pos="-3.75 0.25 -0.5" />
                            <Vertex pos="-4.25 -0.25 0.500001" />
                            <Vertex pos="-4.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2368 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2240 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2368 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="-26.5 59.25 11" rot="1 0 0 0" scale="" transform="1 0 0 -26.5 0 1 0 59.25 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 0.5" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4.5 -0.25 0.5" />
                            <Vertex pos="-4.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2304 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="-24 68.25 12" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 68.25 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.500001" />
                            <Vertex pos="2 0.25 -0.500001" />
                            <Vertex pos="2 -0.25 0" />
                            <Vertex pos="2 -0.25 -0.500001" />
                            <Vertex pos="-2 0.25 0.500001" />
                            <Vertex pos="-2 0.25 -0.500001" />
                            <Vertex pos="-2 -0.25 0" />
                            <Vertex pos="-2 -0.25 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="-24 68.75 12" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 68.75 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="-28 68.25 10" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 68.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.500003" />
                            <Vertex pos="2 0.25 -0.500002" />
                            <Vertex pos="2 -0.25 2.86102e-006" />
                            <Vertex pos="2 -0.25 -0.500002" />
                            <Vertex pos="-2 0.25 0.500003" />
                            <Vertex pos="-2 0.25 -0.500002" />
                            <Vertex pos="-2 -0.25 2.86102e-006" />
                            <Vertex pos="-2 -0.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-28 68.75 10" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 68.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-29.25 72 8" rot="1 0 0 0" scale="" transform="1 0 0 -29.25 0 1 0 72 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-29.75 72 8" rot="1 0 0 0" scale="" transform="1 0 0 -29.75 0 1 0 72 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.500001" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.500001" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 9.53674e-007" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 9.53674e-007" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-30.25 61.75 11" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 61.75 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 1.90735e-006" />
                            <Vertex pos="0.25 2.25 -0.500002" />
                            <Vertex pos="0.25 -1.74999 0" />
                            <Vertex pos="0.25 -1.75 -0.500002" />
                            <Vertex pos="-0.25 2.25 0.500002" />
                            <Vertex pos="-0.25 2.25 -0.500002" />
                            <Vertex pos="-0.25 -2.24999 0.5" />
                            <Vertex pos="-0.25 -2.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1344 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.70711 -0.707103 7.08062e-006 -1.4142" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 -3.18444e-007 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-30.75 61.5 11" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 61.5 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.5" />
                            <Vertex pos="0.25 2.5 -0.5" />
                            <Vertex pos="0.25 -2 0.499999" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2.5 0.5" />
                            <Vertex pos="-0.25 2.5 -0.5" />
                            <Vertex pos="-0.25 -2.5 0.499999" />
                            <Vertex pos="-0.25 -2.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -2.02656e-007 1 -0.499999" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-32 63.75 10" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 63.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 -9.53674e-007" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 -9.53674e-007" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-32 63.25 10" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 63.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-36.25 63.75 9" rot="1 0 0 0" scale="" transform="1 0 0 -36.25 0 1 0 63.75 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 -1.90735e-006" />
                            <Vertex pos="2.25 0.25 -0.5" />
                            <Vertex pos="2.25 -0.25 0.499999" />
                            <Vertex pos="2.25 -0.25 -0.5" />
                            <Vertex pos="-1.75 0.25 -1.90735e-006" />
                            <Vertex pos="-1.75 0.25 -0.5" />
                            <Vertex pos="-2.25 -0.25 0.499999" />
                            <Vertex pos="-2.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1856 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1728 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176775" album="" material="bm_edge_white" texgens="1 0 0 -1728 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1856 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-36.5 63.25 9" rot="1 0 0 0" scale="" transform="1 0 0 -36.5 0 1 0 63.25 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.5" />
                            <Vertex pos="2.5 0.25 -0.5" />
                            <Vertex pos="2.5 -0.25 0.5" />
                            <Vertex pos="2.5 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2.5 -0.25 0.5" />
                            <Vertex pos="-2.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1792 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-38.25 67.75 9" rot="1 0 0 0" scale="" transform="1 0 0 -38.25 0 1 0 67.75 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 9.53674e-007" />
                            <Vertex pos="0.25 4.25 -0.500002" />
                            <Vertex pos="0.25 -3.75 1.90735e-006" />
                            <Vertex pos="0.25 -3.75 -0.500002" />
                            <Vertex pos="-0.25 4.25 0.500001" />
                            <Vertex pos="-0.25 4.25 -0.500002" />
                            <Vertex pos="-0.25 -4.25 0.500002" />
                            <Vertex pos="-0.25 -4.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1984 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1856 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 8.42937e-008 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-38.75 67.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 67.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.5 0.5" />
                            <Vertex pos="0.25 4.5 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4.5 0.5" />
                            <Vertex pos="-0.25 4.5 -0.5" />
                            <Vertex pos="-0.25 -4.5 0.5" />
                            <Vertex pos="-0.25 -4.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-38.25 78 5" rot="1 0 0 0" scale="" transform="1 0 0 -38.25 0 1 0 78 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 -1.90735e-006" />
                            <Vertex pos="0.25 6 -0.499998" />
                            <Vertex pos="0.25 -6 -1.90735e-006" />
                            <Vertex pos="0.25 -6 -0.499998" />
                            <Vertex pos="-0.25 6 0.499998" />
                            <Vertex pos="-0.25 6 -0.499998" />
                            <Vertex pos="-0.25 -6 0.499998" />
                            <Vertex pos="-0.25 -6 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176775" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499998" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-38.75 78 5" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 78 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.5" />
                            <Vertex pos="0.25 6 -0.5" />
                            <Vertex pos="0.25 -6 0.5" />
                            <Vertex pos="0.25 -6 -0.5" />
                            <Vertex pos="-0.25 6 0.5" />
                            <Vertex pos="-0.25 6 -0.5" />
                            <Vertex pos="-0.25 -6 0.5" />
                            <Vertex pos="-0.25 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-29.25 80 5" rot="1 0 0 0" scale="" transform="1 0 0 -29.25 0 1 0 80 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-29.75 80 5" rot="1 0 0 0" scale="" transform="1 0 0 -29.75 0 1 0 80 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 4.76837e-007" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 4.76837e-007" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707106 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-38.25 96 3" rot="1 0 0 0" scale="" transform="1 0 0 -38.25 0 1 0 96 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 1.7643e-005" />
                            <Vertex pos="0.25 4 -0.500002" />
                            <Vertex pos="0.25 -4 1.7643e-005" />
                            <Vertex pos="0.25 -4 -0.500002" />
                            <Vertex pos="-0.25 4 0.500002" />
                            <Vertex pos="-0.25 4 -0.500002" />
                            <Vertex pos="-0.25 -4 0.500002" />
                            <Vertex pos="-0.25 -4 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707096 0 0.707118 -0.176786" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-38.75 96 3" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 96 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-29.25 96 3" rot="1 0 0 0" scale="" transform="1 0 0 -29.25 0 1 0 96 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-29.75 96 3" rot="1 0 0 0" scale="" transform="1 0 0 -29.75 0 1 0 96 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.00001 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4.00001 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4.00001 4.76837e-007" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4.00001 4.76837e-007" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -1.00136e-005 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="2.00271e-005 -1 -2.00271e-005 -4.00001" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707106 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-38.25 104 9" rot="1 0 0 0" scale="" transform="1 0 0 -38.25 0 1 0 104 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 9.53674e-007" />
                            <Vertex pos="0.25 4 -0.500002" />
                            <Vertex pos="0.25 -3.99999 9.53674e-007" />
                            <Vertex pos="0.25 -4 -0.500002" />
                            <Vertex pos="-0.25 4 0.500001" />
                            <Vertex pos="-0.25 4 -0.500002" />
                            <Vertex pos="-0.25 -3.99999 0.500001" />
                            <Vertex pos="-0.25 -4 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="1.00136e-005 -1 1.00135e-005 -3.99999" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-38.75 104 9" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 104 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-29.25 104 9" rot="1 0 0 0" scale="" transform="1 0 0 -29.25 0 1 0 104 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-29.75 104 9" rot="1 0 0 0" scale="" transform="1 0 0 -29.75 0 1 0 104 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.499999" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -3.99999 0.499999" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 -9.53674e-007" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -3.99999 -9.53674e-007" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-2.00272e-005 -1 2.00272e-005 -3.99999" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-38.25 110 8" rot="1 0 0 0" scale="" transform="1 0 0 -38.25 0 1 0 110 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.00001 0" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2.00001 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -2.00272e-005 -2.00001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-38.75 110 8" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 110 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-29.25 110 7" rot="1 0 0 0" scale="" transform="1 0 0 -29.25 0 1 0 110 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-29.75 110 7" rot="1 0 0 0" scale="" transform="1 0 0 -29.75 0 1 0 110 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.00001 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2.00001 -4.76837e-007" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 -4.76837e-007" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -1.00136e-005 -2.00001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-29.25 114 3" rot="1 0 0 0" scale="" transform="1 0 0 -29.25 0 1 0 114 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-29.75 114 3" rot="1 0 0 0" scale="" transform="1 0 0 -29.75 0 1 0 114 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -1.99999 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 4.76837e-007" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -1.99999 4.76837e-007" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-2.00271e-005 -1 2.00271e-005 -1.99999" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707106 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-38.25 116.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -38.25 0 1 0 116.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.75001 1.43051e-006" />
                            <Vertex pos="0.25 3.75 -0.500002" />
                            <Vertex pos="0.25 -4.24999 2.38419e-006" />
                            <Vertex pos="0.25 -4.25 -0.500002" />
                            <Vertex pos="-0.25 4.25001 0.500001" />
                            <Vertex pos="-0.25 4.25 -0.500002" />
                            <Vertex pos="-0.25 -4.24999 0.500002" />
                            <Vertex pos="-0.25 -4.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -1.41612e-005 -2.82843" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="1.00135e-005 -1 1.00135e-005 -4.24999" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 8.42937e-008 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-38.75 116.5 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 116.5 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4.5 0.5" />
                            <Vertex pos="0.25 -4.5 -0.5" />
                            <Vertex pos="-0.25 4.5 0.5" />
                            <Vertex pos="-0.25 4.5 -0.5" />
                            <Vertex pos="-0.25 -4.5 0.5" />
                            <Vertex pos="-0.25 -4.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3200 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -3.0052" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="-36.25 120.25 5.50003" rot="1 0 0 0" scale="" transform="1 0 0 -36.25 0 1 0 120.25 0 0 1 5.50003 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25001 0.25 0.50003" />
                            <Vertex pos="2.25001 0.25 -0.500031" />
                            <Vertex pos="2.25001 -0.25 2.95639e-005" />
                            <Vertex pos="2.25001 -0.25 -0.500031" />
                            <Vertex pos="-2.25001 0.25 0.50003" />
                            <Vertex pos="-2.25 0.25 -0.500031" />
                            <Vertex pos="-1.75001 -0.25 2.95639e-005" />
                            <Vertex pos="-1.75 -0.25 -0.500031" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25001" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 -7.08024e-006 -1.41422" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2624 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2496 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176798" album="" material="bm_edge_white" texgens="1 0 0 -2496 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500031" album="" material="bm_edge_white" texgens="-1 0 0 2624 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-36.5 120.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -36.5 0 1 0 120.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.5" />
                            <Vertex pos="2.5 0.25 -0.5" />
                            <Vertex pos="2.5 -0.25 0.5" />
                            <Vertex pos="2.5 -0.25 -0.5" />
                            <Vertex pos="-2.5 0.25 0.5" />
                            <Vertex pos="-2.5 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-34.25 122.25 6" rot="1 0 0 0" scale="" transform="1 0 0 -34.25 0 1 0 122.25 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 1.90735e-006" />
                            <Vertex pos="0.25 1.74999 -0.500002" />
                            <Vertex pos="0.25 -2.25 2.38419e-006" />
                            <Vertex pos="0.25 -2.25 -0.500002" />
                            <Vertex pos="-0.25 2.25 0.500002" />
                            <Vertex pos="-0.25 2.24999 -0.500002" />
                            <Vertex pos="-0.25 -2.25 0.500002" />
                            <Vertex pos="-0.25 -2.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -1.41612e-005 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-34.75 122.5 6" rot="1 0 0 0" scale="" transform="1 0 0 -34.75 0 1 0 122.5 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.99999 0.5" />
                            <Vertex pos="0.25 1.99999 -0.5" />
                            <Vertex pos="0.25 -2.5 0.5" />
                            <Vertex pos="0.25 -2.5 -0.5" />
                            <Vertex pos="-0.25 2.49999 0.5" />
                            <Vertex pos="-0.25 2.49999 -0.5" />
                            <Vertex pos="-0.25 -2.5 0.5" />
                            <Vertex pos="-0.25 -2.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.59098" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-27.75 115.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -27.75 0 1 0 115.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.25 -2.86102e-006" />
                            <Vertex pos="1.75 0.25 -0.499998" />
                            <Vertex pos="2.25 -0.25 0.499998" />
                            <Vertex pos="2.25 -0.25 -0.499998" />
                            <Vertex pos="-2.25 0.25 -2.86102e-006" />
                            <Vertex pos="-2.25 0.25 -0.499998" />
                            <Vertex pos="-2.25 -0.25 0.499998" />
                            <Vertex pos="-2.25 -0.25 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176775" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499998" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-27.5 115.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -27.5 0 1 0 115.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2.5 -0.25 0.5" />
                            <Vertex pos="2.5 -0.25 -0.5" />
                            <Vertex pos="-2.5 0.25 0.5" />
                            <Vertex pos="-2.5 0.25 -0.5" />
                            <Vertex pos="-2.5 -0.25 0.5" />
                            <Vertex pos="-2.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-25.25 117.5 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -25.25 0 1 0 117.5 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.5" />
                            <Vertex pos="0.25 2.5 -0.5" />
                            <Vertex pos="0.25 -2.50001 0.5" />
                            <Vertex pos="0.25 -2.50001 -0.5" />
                            <Vertex pos="-0.25 2.5 0.5" />
                            <Vertex pos="-0.25 2.5 -0.5" />
                            <Vertex pos="-0.25 -2.00001 0.5" />
                            <Vertex pos="-0.25 -2.00001 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3328 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.591" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-25.75 117.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -25.75 0 1 0 117.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.499998" />
                            <Vertex pos="0.25 2.25 -0.499999" />
                            <Vertex pos="0.25 -2.25 0.499999" />
                            <Vertex pos="0.25 -2.25 -0.499999" />
                            <Vertex pos="-0.25 2.25 -2.38419e-006" />
                            <Vertex pos="-0.25 2.25 -0.499999" />
                            <Vertex pos="-0.25 -1.75 -9.53674e-007" />
                            <Vertex pos="-0.25 -1.75 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3520 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3392 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 2.52882e-007 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-25.25 122 6" rot="1 0 0 0" scale="" transform="1 0 0 -25.25 0 1 0 122 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="-25.75 122 6" rot="1 0 0 0" scale="" transform="1 0 0 -25.75 0 1 0 122 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.99999 0.499999" />
                            <Vertex pos="0.25 2 -0.499999" />
                            <Vertex pos="0.25 -2 0.499999" />
                            <Vertex pos="0.25 -2 -0.499999" />
                            <Vertex pos="-0.25 1.99999 -1.43051e-006" />
                            <Vertex pos="-0.25 2 -0.499999" />
                            <Vertex pos="-0.25 -2 -1.43051e-006" />
                            <Vertex pos="-0.25 -2 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 1.00136e-005 -1.99999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="-32.25 124.25 6.00003" rot="1 0 0 0" scale="" transform="1 0 0 -32.25 0 1 0 124.25 0 0 1 6.00003 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25002 0.249992 0.500031" />
                            <Vertex pos="2.25002 0.25 -0.500031" />
                            <Vertex pos="2.25002 -0.250008 3.00407e-005" />
                            <Vertex pos="2.25002 -0.25 -0.500031" />
                            <Vertex pos="-2.25001 0.249992 0.500031" />
                            <Vertex pos="-2.25001 0.25 -0.500031" />
                            <Vertex pos="-1.75001 -0.250008 3.00407e-005" />
                            <Vertex pos="-1.75001 -0.25 -0.500031" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25002" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 -5.65786e-006 -1.41422" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 8.00143e-006 -0.249996" album="" material="bm_edge_white" texgens="-1 0 0 2624 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -1.59721e-005 -0.250008" album="" material="bm_edge_white" texgens="1 0 0 -2496 0 0 -1 -0.0078125 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176804" album="" material="bm_edge_white" texgens="1 0 0 -2496 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500031" album="" material="bm_edge_white" texgens="-1 0 0 2624 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-32.5 124.75 6" rot="1 0 0 0" scale="" transform="1 0 0 -32.5 0 1 0 124.75 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.5" />
                            <Vertex pos="2.5 0.25 -0.5" />
                            <Vertex pos="2.5 -0.25 0.5" />
                            <Vertex pos="2.5 -0.25 -0.5" />
                            <Vertex pos="-2.5 0.25 0.5" />
                            <Vertex pos="-2.5 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-30.25 126 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 126 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 4.76837e-007" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2.00001 4.76837e-007" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2.00001 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-1.00136e-005 -1 -1.00136e-005 -2.00001" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707106 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-30.75 126 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 126 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-30.25 130.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 130.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 1.90735e-006" />
                            <Vertex pos="0.25 1.75 -0.500002" />
                            <Vertex pos="0.25 -2.25 2.38419e-006" />
                            <Vertex pos="0.25 -2.25 -0.500002" />
                            <Vertex pos="-0.25 2.25 0.500002" />
                            <Vertex pos="-0.25 2.25 -0.500002" />
                            <Vertex pos="-0.25 -2.25 0.500002" />
                            <Vertex pos="-0.25 -2.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-30.75 130.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 130.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2.5 0.5" />
                            <Vertex pos="0.25 -2.5 -0.5" />
                            <Vertex pos="-0.25 2.5 0.5" />
                            <Vertex pos="-0.25 2.5 -0.5" />
                            <Vertex pos="-0.25 -2.5 0.5" />
                            <Vertex pos="-0.25 -2.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.59099" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-23.75 123.75 6.99999" rot="1 0 0 0" scale="" transform="1 0 0 -23.75 0 1 0 123.75 0 0 1 6.99999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.249992 -7.62939e-006" />
                            <Vertex pos="1.75 0.25 -0.499993" />
                            <Vertex pos="2.25 -0.250008 0.499993" />
                            <Vertex pos="2.25 -0.25 -0.499993" />
                            <Vertex pos="-2.25 0.249992 -7.62939e-006" />
                            <Vertex pos="-2.25 0.25 -0.499993" />
                            <Vertex pos="-2.25 -0.250008 0.499993" />
                            <Vertex pos="-2.25 -0.25 -0.499993" />
                        </Vertices>
                        <Face id="0" plane="0.707104 0.70711 5.64778e-006 -1.4142" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 1.60043e-005 -0.249992" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -7.98713e-006 -0.250004" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176766" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499993" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-23.5 123.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 123.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2.5 -0.25 0.5" />
                            <Vertex pos="2.5 -0.25 -0.5" />
                            <Vertex pos="-2.5 0.25 0.5" />
                            <Vertex pos="-2.5 0.25 -0.5" />
                            <Vertex pos="-2.5 -0.25 0.5" />
                            <Vertex pos="-2.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-21.25 125.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 125.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.5" />
                            <Vertex pos="0.25 1.75 -0.5" />
                            <Vertex pos="0.25 -2.24999 0.5" />
                            <Vertex pos="0.25 -2.24999 -0.5" />
                            <Vertex pos="-0.25 2.25 0.5" />
                            <Vertex pos="-0.25 2.25 -0.5" />
                            <Vertex pos="-0.25 -1.74999 0.5" />
                            <Vertex pos="-0.25 -1.74999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3392 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3264 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-21.75 125.75 7" rot="1 0 0 0" scale="" transform="1 0 0 -21.75 0 1 0 125.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.499999" />
                            <Vertex pos="0.25 1.75 -0.499998" />
                            <Vertex pos="0.25 -2.24999 0.499999" />
                            <Vertex pos="0.25 -2.24999 -0.499998" />
                            <Vertex pos="-0.25 2.25 -1.43051e-006" />
                            <Vertex pos="-0.25 2.25 -0.499998" />
                            <Vertex pos="-0.25 -1.74999 -1.43051e-006" />
                            <Vertex pos="-0.25 -1.74999 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3520 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3392 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499998" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-28.25 132.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -28.25 0 1 0 132.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75001 0.25 0.500004" />
                            <Vertex pos="1.75001 0.25 -0.500004" />
                            <Vertex pos="2.25001 -0.25 3.33786e-006" />
                            <Vertex pos="2.25001 -0.25 -0.500004" />
                            <Vertex pos="-2.25001 0.25 0.500004" />
                            <Vertex pos="-2.25 0.25 -0.500004" />
                            <Vertex pos="-1.75001 -0.25 3.33786e-006" />
                            <Vertex pos="-1.75 -0.25 -0.500004" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41422" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 -7.08061e-006 -1.41422" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2496 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 -2496 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500004" album="" material="bm_edge_white" texgens="-1 0 0 2624 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-28.75 132.75 7" rot="1 0 0 0" scale="" transform="1 0 0 -28.75 0 1 0 132.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75001 0.25 0.5" />
                            <Vertex pos="1.75001 0.25 -0.5" />
                            <Vertex pos="2.25001 -0.25 0.5" />
                            <Vertex pos="2.25001 -0.25 -0.5" />
                            <Vertex pos="-2.25001 0.25 0.5" />
                            <Vertex pos="-2.25001 0.25 -0.5" />
                            <Vertex pos="-1.75001 -0.25 0.5" />
                            <Vertex pos="-1.75001 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41422" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41422" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2752 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2624 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2752 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-26.25 134.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -26.25 0 1 0 134.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 1.43051e-006" />
                            <Vertex pos="0.25 1.75 -0.500001" />
                            <Vertex pos="0.25 -2.24998 1.43051e-006" />
                            <Vertex pos="0.25 -2.24998 -0.500001" />
                            <Vertex pos="-0.25 2.25 0.500001" />
                            <Vertex pos="-0.25 2.25 -0.500001" />
                            <Vertex pos="-0.25 -1.74998 0.500001" />
                            <Vertex pos="-0.25 -1.74998 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.4142" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707106 0 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-26.75 134.75 7" rot="1 0 0 0" scale="" transform="1 0 0 -26.75 0 1 0 134.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.5" />
                            <Vertex pos="0.25 1.75 -0.5" />
                            <Vertex pos="0.25 -2.25002 0.5" />
                            <Vertex pos="0.25 -2.25002 -0.5" />
                            <Vertex pos="-0.25 2.25 0.5" />
                            <Vertex pos="-0.25 2.25 -0.5" />
                            <Vertex pos="-0.25 -1.75002 0.5" />
                            <Vertex pos="-0.25 -1.75002 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2752 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41423" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="-22.25 136.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -22.25 0 1 0 136.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.25 0.499999" />
                            <Vertex pos="4.25 0.25 -0.499998" />
                            <Vertex pos="4.25 -0.25 -1.90735e-006" />
                            <Vertex pos="4.25 -0.25 -0.499998" />
                            <Vertex pos="-4.25 0.25 0.499999" />
                            <Vertex pos="-4.25 0.25 -0.499998" />
                            <Vertex pos="-3.75 -0.25 -1.90735e-006" />
                            <Vertex pos="-3.75 -0.25 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3136 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3008 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -3008 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499998" album="" material="bm_edge_white" texgens="-1 0 0 3136 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="-22.5 136.75 7" rot="1 0 0 0" scale="" transform="1 0 0 -22.5 0 1 0 136.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3200 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3072 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3200 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-20 127.75 6.99999" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 127.75 0 0 1 6.99999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.00001 0.25 -7.62939e-006" />
                            <Vertex pos="2.00001 0.25 -0.499993" />
                            <Vertex pos="2.00001 -0.25 0.499993" />
                            <Vertex pos="2.00001 -0.25 -0.499993" />
                            <Vertex pos="-2.00001 0.25 -7.62939e-006" />
                            <Vertex pos="-2.00001 0.25 -0.499993" />
                            <Vertex pos="-1.50001 -0.25 0.499993" />
                            <Vertex pos="-1.50001 -0.25 -0.499993" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2.00001" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.23744" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176771" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499993" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-19.75 127.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -19.75 0 1 0 127.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75001 0.25 0.5" />
                            <Vertex pos="1.75001 0.25 -0.5" />
                            <Vertex pos="1.75001 -0.25 0.5" />
                            <Vertex pos="1.75001 -0.25 -0.5" />
                            <Vertex pos="-1.75001 0.25 0.5" />
                            <Vertex pos="-1.75001 0.25 -0.5" />
                            <Vertex pos="-1.25001 -0.25 0.5" />
                            <Vertex pos="-1.25001 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75001" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.06067" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1728 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="-12 127.75 13" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 127.75 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.00001 0.249992 1.14441e-005" />
                            <Vertex pos="6.00003 0.249985 -0.500002" />
                            <Vertex pos="5.49999 -0.25 0.500001" />
                            <Vertex pos="5.50003 -0.25 -0.500002" />
                            <Vertex pos="-6.00003 0.249992 1.14441e-005" />
                            <Vertex pos="-6.00003 0.249985 -0.500002" />
                            <Vertex pos="-6.00003 -0.25 0.500001" />
                            <Vertex pos="-6.00003 -0.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="0.707101 -0.707112 2.83224e-005 -4.06584" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.00003" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -1.40067e-005 -0.249992" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707105 0.707108 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-12.25 127.25 13" rot="1 0 0 0" scale="" transform="1 0 0 -12.25 0 1 0 127.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.75002 0.25 0.5" />
                            <Vertex pos="5.75002 0.25 -0.5" />
                            <Vertex pos="5.25002 -0.25 0.5" />
                            <Vertex pos="5.25002 -0.25 -0.5" />
                            <Vertex pos="-5.75002 0.25 0.5" />
                            <Vertex pos="-5.75002 0.25 -0.5" />
                            <Vertex pos="-5.75002 -0.25 0.5" />
                            <Vertex pos="-5.75002 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -3.8891" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5.75002" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 832 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 832 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-3.75001 136.25 13" rot="1 0 0 0" scale="" transform="1 0 0 -3.75001 0 1 0 136.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.25 0.25 0.499959" />
                            <Vertex pos="6.25001 0.25 -0.499959" />
                            <Vertex pos="5.75 -0.25 -4.1008e-005" />
                            <Vertex pos="5.75001 -0.25 -0.499959" />
                            <Vertex pos="-5.75001 0.25 0.499959" />
                            <Vertex pos="-5.75001 0.25 -0.499959" />
                            <Vertex pos="-6.25001 -0.25 -4.1008e-005" />
                            <Vertex pos="-6.25001 -0.25 -0.499959" />
                        </Vertices>
                        <Face id="0" plane="0.7071 -0.707114 1.41635e-005 -4.2426" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0.00561523 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.24265" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0.00561523 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2496 0 0 -1 0.00561523 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2368 0 0 -1 0.00561523 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176748" album="" material="bm_edge_white" texgens="1 0 0 -2368 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499959" album="" material="bm_edge_white" texgens="-1 0 0 2496 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="-3.25002 136.75 13" rot="1 0 0 0" scale="" transform="1 0 0 -3.25002 0 1 0 136.75 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.25001 0.25 0.5" />
                            <Vertex pos="6.25001 0.25 -0.5" />
                            <Vertex pos="5.75001 -0.25 0.5" />
                            <Vertex pos="5.75001 -0.25 -0.5" />
                            <Vertex pos="-5.75001 0.25 0.5" />
                            <Vertex pos="-5.75001 0.25 -0.5" />
                            <Vertex pos="-6.25001 -0.25 0.5" />
                            <Vertex pos="-6.25001 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -4.24265" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.24265" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2368.01 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2240.01 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2240.01 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2368.01 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="2.75 128.5 13" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 128.5 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.49998 0.5" />
                            <Vertex pos="0.25 8.49998 -0.499999" />
                            <Vertex pos="0.25 -8.5 0.5" />
                            <Vertex pos="0.25 -8.5 -0.5" />
                            <Vertex pos="-0.25 7.99998 0.5" />
                            <Vertex pos="-0.25 7.99998 -0.499999" />
                            <Vertex pos="-0.25 -8.5 0.5" />
                            <Vertex pos="-0.25 -8.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4224 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -5.83362" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 5.96047e-008 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="2.25 128.25 13" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 128.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.24998 0.499999" />
                            <Vertex pos="0.25 8.24998 -0.499999" />
                            <Vertex pos="0.25 -8.25 0.499999" />
                            <Vertex pos="0.25 -8.25 -0.5" />
                            <Vertex pos="-0.25 7.74998 -9.53674e-007" />
                            <Vertex pos="-0.25 7.74998 -0.499999" />
                            <Vertex pos="-0.25 -8.25 -9.53674e-007" />
                            <Vertex pos="-0.25 -8.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4160 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4032 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -5.65684" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 6.14109e-008 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-6.25 124 13" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 124 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.99999 9.53674e-007" />
                            <Vertex pos="0.25 3.99999 -0.499999" />
                            <Vertex pos="0.25 -3.99999 0" />
                            <Vertex pos="0.25 -3.99999 -0.5" />
                            <Vertex pos="-0.25 3.49999 0.500001" />
                            <Vertex pos="-0.25 3.49999 -0.499999" />
                            <Vertex pos="-0.25 -3.99999 0.5" />
                            <Vertex pos="-0.25 -3.99999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.65164" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.99999" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 -9.55331e-008 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 1.2666e-007 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="-6.75 123.75 13" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 123.75 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.74999 0.5" />
                            <Vertex pos="0.25 3.74999 -0.499999" />
                            <Vertex pos="0.25 -3.74999 0.5" />
                            <Vertex pos="0.25 -3.74999 -0.5" />
                            <Vertex pos="-0.25 3.24999 0.5" />
                            <Vertex pos="-0.25 3.24999 -0.499999" />
                            <Vertex pos="-0.25 -3.74999 0.5" />
                            <Vertex pos="-0.25 -3.74999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1984 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1856 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.47487" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.74999" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 1.35104e-007 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="-6.25 96 5" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 96 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.00001 4.76837e-007" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -3.99999 4.76837e-007" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4.00001 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -3.49999 0.5" />
                            <Vertex pos="-0.25 -3.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -2.00271e-005 -4.00001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707103 -0.70711 7.08071e-006 -2.65166" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707106 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="-6.75 96.25 5" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 96.25 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.75 0.5" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0.25 -3.75 0.5" />
                            <Vertex pos="0.25 -3.75 -0.5" />
                            <Vertex pos="-0.25 3.75 0.5" />
                            <Vertex pos="-0.25 3.75 -0.5" />
                            <Vertex pos="-0.25 -3.25 0.5" />
                            <Vertex pos="-0.25 -3.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.75" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.47487" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="2.75 91.5 5" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 91.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.5 0.5" />
                            <Vertex pos="0.25 8.5 -0.5" />
                            <Vertex pos="0.25 -8.50001 0.5" />
                            <Vertex pos="0.25 -8.50001 -0.5" />
                            <Vertex pos="-0.25 8.5 0.5" />
                            <Vertex pos="-0.25 8.5 -0.5" />
                            <Vertex pos="-0.25 -8.00001 0.5" />
                            <Vertex pos="-0.25 -8.00001 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4992 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4864 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -5.83364" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="2.25 91.75 5" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 91.75 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.25001 0.5" />
                            <Vertex pos="0.25 8.25 -0.5" />
                            <Vertex pos="0.25 -8.24999 0.5" />
                            <Vertex pos="0.25 -8.25 -0.5" />
                            <Vertex pos="-0.25 8.25001 -4.76837e-007" />
                            <Vertex pos="-0.25 8.25 -0.5" />
                            <Vertex pos="-0.25 -7.74999 -4.76837e-007" />
                            <Vertex pos="-0.25 -7.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 5056 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4928 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -9.53674e-006 -8.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707114 -0.707099 1.41612e-005 -5.65679" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -4928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -4928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="-10 92.25 5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 92.25 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.499998" />
                            <Vertex pos="3.5 0.25 -0.499997" />
                            <Vertex pos="4 -0.250008 -2.86102e-006" />
                            <Vertex pos="4 -0.25 -0.499997" />
                            <Vertex pos="-4 0.25 0.499998" />
                            <Vertex pos="-4 0.25 -0.499997" />
                            <Vertex pos="-4 -0.250008 -2.86102e-006" />
                            <Vertex pos="-4 -0.25 -0.499997" />
                        </Vertices>
                        <Face id="0" plane="0.707118 0.707096 1.12953e-005 -2.65169" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -1.59742e-005 -0.250008" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707102 0.707112 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499997" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="-10.25 92.75 5" rot="1 0 0 0" scale="" transform="1 0 0 -10.25 0 1 0 92.75 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 0.5" />
                            <Vertex pos="3.25 0.25 -0.5" />
                            <Vertex pos="3.75 -0.25 0.5" />
                            <Vertex pos="3.75 -0.25 -0.5" />
                            <Vertex pos="-3.75 0.25 0.5" />
                            <Vertex pos="-3.75 0.25 -0.5" />
                            <Vertex pos="-3.75 -0.25 0.5" />
                            <Vertex pos="-3.75 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.47487" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1984 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1984 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2112 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="-5.75001 83.75 4.99999" rot="1 0 0 0" scale="" transform="1 0 0 -5.75001 0 1 0 83.75 0 0 1 4.99999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.74999 0.25 2.6226e-005" />
                            <Vertex pos="7.74999 0.25 -0.499994" />
                            <Vertex pos="8.24999 -0.25 0.499995" />
                            <Vertex pos="8.24999 -0.25 -0.499994" />
                            <Vertex pos="-8.24999 0.25 2.6226e-005" />
                            <Vertex pos="-8.24999 0.25 -0.499994" />
                            <Vertex pos="-8.24999 -0.25 0.499995" />
                            <Vertex pos="-8.24999 -0.25 -0.499994" />
                        </Vertices>
                        <Face id="0" plane="0.707106 0.707107 0 -5.65684" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8.24999" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707085 0.707129 -0.17679" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499994" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="-5.5 83.25 5" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 83.25 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.99999 0.25 0.5" />
                            <Vertex pos="7.99999 0.25 -0.5" />
                            <Vertex pos="8.49999 -0.25 0.5" />
                            <Vertex pos="8.49999 -0.25 -0.5" />
                            <Vertex pos="-8.5 0.25 0.5" />
                            <Vertex pos="-8.5 0.25 -0.5" />
                            <Vertex pos="-8.5 -0.25 0.5" />
                            <Vertex pos="-8.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707106 0.707107 0 -5.83362" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2176 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="-4.25 22 1" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 22 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.19209e-007" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 1.19209e-007" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 1.5 0.5" />
                            <Vertex pos="-0.25 1.5 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.23744" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="-4.75 21.75 1" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 21.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.5" />
                            <Vertex pos="0.25 1.75 -0.5" />
                            <Vertex pos="0.25 -1.75 0.5" />
                            <Vertex pos="0.25 -1.75 -0.5" />
                            <Vertex pos="-0.25 1.25 0.5" />
                            <Vertex pos="-0.25 1.25 -0.5" />
                            <Vertex pos="-0.25 -1.75 0.5" />
                            <Vertex pos="-0.25 -1.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1344 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.06066" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="-5 23.75 1" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 23.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 2.38419e-007" />
                            <Vertex pos="1 0.25 -0.500001" />
                            <Vertex pos="0.5 -0.25 0.500001" />
                            <Vertex pos="0.5 -0.25 -0.500001" />
                            <Vertex pos="-1 0.25 2.38419e-007" />
                            <Vertex pos="-1 0.25 -0.500001" />
                            <Vertex pos="-1 -0.25 0.500001" />
                            <Vertex pos="-1 -0.25 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707106 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="-5.25 23.25 1" rot="1 0 0 0" scale="" transform="1 0 0 -5.25 0 1 0 23.25 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.25 0.5" />
                            <Vertex pos="0.75 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.749999 0.25 0.5" />
                            <Vertex pos="-0.749999 0.25 -0.5" />
                            <Vertex pos="-0.749999 -0.25 0.5" />
                            <Vertex pos="-0.749999 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.353553" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.749999" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1984 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1984 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2112 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="-36.25 28.75 -3" rot="1 0 0 0" scale="" transform="1 0 0 -36.25 0 1 0 28.75 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.25 -8.58307e-006" />
                            <Vertex pos="0.25 5.25 -0.499999" />
                            <Vertex pos="0.25 -4.75001 -4.29153e-006" />
                            <Vertex pos="0.25 -4.75001 -0.499999" />
                            <Vertex pos="-0.25 5.25 0.499995" />
                            <Vertex pos="-0.25 5.25 -0.499999" />
                            <Vertex pos="-0.25 -5.25001 0.499999" />
                            <Vertex pos="-0.25 -5.25001 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 -0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 -0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5.25" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 -0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -3.53554" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 -0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707109 2.68936e-007 0.707104 -0.176773" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="-36.75 28.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -36.75 0 1 0 28.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.5 0.5" />
                            <Vertex pos="0.25 5.5 -0.5" />
                            <Vertex pos="0.25 -5 0.5" />
                            <Vertex pos="0.25 -5 -0.5" />
                            <Vertex pos="-0.25 5.5 0.5" />
                            <Vertex pos="-0.25 5.5 -0.5" />
                            <Vertex pos="-0.25 -5.5 0.5" />
                            <Vertex pos="-0.25 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -3.71231" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="-31.25 23.75 -3" rot="1 0 0 0" scale="" transform="1 0 0 -31.25 0 1 0 23.75 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.25 0.25 9.53674e-007" />
                            <Vertex pos="5.25 0.25 -0.500001" />
                            <Vertex pos="5.25 -0.25 0.500001" />
                            <Vertex pos="5.25 -0.25 -0.500001" />
                            <Vertex pos="-4.75 0.25 9.53674e-007" />
                            <Vertex pos="-4.75 0.25 -0.500001" />
                            <Vertex pos="-5.25 -0.25 0.500001" />
                            <Vertex pos="-5.25 -0.25 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.53553" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3136 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3008 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -3008 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 3136 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="-31.5 23.25 -3" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 23.25 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 0.25 0.5" />
                            <Vertex pos="5.5 0.25 -0.5" />
                            <Vertex pos="5.5 -0.25 0.5" />
                            <Vertex pos="5.5 -0.25 -0.5" />
                            <Vertex pos="-5 0.25 0.5" />
                            <Vertex pos="-5 0.25 -0.5" />
                            <Vertex pos="-5.5 -0.25 0.5" />
                            <Vertex pos="-5.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.71231" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3200 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3072 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3200 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="-27.25 33.25 -3" rot="1 0 0 0" scale="" transform="1 0 0 -27.25 0 1 0 33.25 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.75 0.5" />
                            <Vertex pos="0.25 0.75 -0.5" />
                            <Vertex pos="0.25 -0.250004 0.5" />
                            <Vertex pos="0.25 -0.250004 -0.5" />
                            <Vertex pos="-0.25 0.75 0.5" />
                            <Vertex pos="-0.25 0.75 -0.5" />
                            <Vertex pos="-0.25 -0.750004 0.5" />
                            <Vertex pos="-0.25 -0.750004 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 320 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -192 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -0.353556" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="-27.75 33 -3" rot="1 0 0 0" scale="" transform="1 0 0 -27.75 0 1 0 33 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 -0.499999" />
                            <Vertex pos="0.25 -0.500008 0.499998" />
                            <Vertex pos="0.25 -0.500004 -0.499999" />
                            <Vertex pos="-0.25 1 -3.57628e-006" />
                            <Vertex pos="-0.25 1 -0.499999" />
                            <Vertex pos="-0.25 -1.00001 -4.76837e-006" />
                            <Vertex pos="-0.25 -1.00001 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707108 -0.707105 0 -0.530335" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 -0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707109 -4.21464e-007 0.707104 -0.176774" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="0" type="0" pos="-27 32.25 -3.00001" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 32.25 0 0 1 -3.00001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.249996 0.499993" />
                            <Vertex pos="1 0.249996 -0.499993" />
                            <Vertex pos="1 -0.249996 6.4373e-006" />
                            <Vertex pos="1 -0.249996 -0.499993" />
                            <Vertex pos="-0.500006 0.249996 0.499993" />
                            <Vertex pos="-0.500006 0.249996 -0.499993" />
                            <Vertex pos="-0.999998 -0.249996 6.4373e-006" />
                            <Vertex pos="-0.999998 -0.249996 -0.499993" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -0.530331" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.249996" album="" material="bm_edge_white" texgens="-1 0 0 2816 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.249996" album="" material="bm_edge_white" texgens="1 0 0 -2688 0 0 -1 0.000976563 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707103 0.707111 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2688 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499993" album="" material="bm_edge_white" texgens="-1 0 0 2816 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="-26.75 32.75 -3" rot="1 0 0 0" scale="" transform="1 0 0 -26.75 0 1 0 32.75 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.25 0.5" />
                            <Vertex pos="0.75 0.25 -0.5" />
                            <Vertex pos="0.75 -0.25 0.5" />
                            <Vertex pos="0.75 -0.25 -0.5" />
                            <Vertex pos="-0.250002 0.25 0.5" />
                            <Vertex pos="-0.250002 0.25 -0.5" />
                            <Vertex pos="-0.750002 -0.25 0.5" />
                            <Vertex pos="-0.750002 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -0.353555" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2752 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2624 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2752 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="-18.25 138 13" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 138 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="258" owner="0" type="0" pos="-18.75 138 13" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 138 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="259" owner="0" type="0" pos="-9.25 138.25 13" rot="1 0 0 0" scale="" transform="1 0 0 -9.25 0 1 0 138.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.5" />
                            <Vertex pos="0.25 1.75 -0.5" />
                            <Vertex pos="0.25 -1.25 0.5" />
                            <Vertex pos="0.25 -1.25 -0.499999" />
                            <Vertex pos="-0.25 1.75 0.5" />
                            <Vertex pos="-0.25 1.75 -0.5" />
                            <Vertex pos="-0.25 -1.75 0.5" />
                            <Vertex pos="-0.25 -1.75 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3648 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3520 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.75" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.06066" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="3.3776e-007 -3.3776e-007 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="260" owner="0" type="0" pos="-9.75 138 13" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 138 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.499999" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -1.5 0.499999" />
                            <Vertex pos="0.25 -1.5 -0.499999" />
                            <Vertex pos="-0.25 2 -9.53674e-007" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 -9.53674e-007" />
                            <Vertex pos="-0.25 -2 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3456 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.23744" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="2.89508e-007 -2.89508e-007 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3456 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="261" owner="0" type="0" pos="-18.25 142 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 142 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -9.53674e-007" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 -9.53674e-007" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.499999" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.499999" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="262" owner="0" type="0" pos="-18.75 142 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 142 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="263" owner="0" type="0" pos="-18.25 146 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 146 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="264" owner="0" type="0" pos="-18.75 146 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 146 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="265" owner="0" type="0" pos="-18.25 151 9" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 151 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 -9.53674e-007" />
                            <Vertex pos="0.25 3 -0.5" />
                            <Vertex pos="0.25 -3 -9.53674e-007" />
                            <Vertex pos="0.25 -3 -0.5" />
                            <Vertex pos="-0.25 3 0.499999" />
                            <Vertex pos="-0.25 3 -0.5" />
                            <Vertex pos="-0.25 -3 0.499999" />
                            <Vertex pos="-0.25 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="266" owner="0" type="0" pos="-18.75 151 9" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 151 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.5" />
                            <Vertex pos="0.25 3 -0.5" />
                            <Vertex pos="0.25 -3 0.5" />
                            <Vertex pos="0.25 -3 -0.5" />
                            <Vertex pos="-0.25 3 0.5" />
                            <Vertex pos="-0.25 3 -0.5" />
                            <Vertex pos="-0.25 -3 0.5" />
                            <Vertex pos="-0.25 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="267" owner="0" type="0" pos="-18.25 161 9" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 161 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 -9.53674e-007" />
                            <Vertex pos="0.25 3 -0.5" />
                            <Vertex pos="0.25 -3 -9.53674e-007" />
                            <Vertex pos="0.25 -3 -0.5" />
                            <Vertex pos="-0.25 3 0.499999" />
                            <Vertex pos="-0.25 3 -0.5" />
                            <Vertex pos="-0.25 -3 0.499999" />
                            <Vertex pos="-0.25 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="268" owner="0" type="0" pos="-18.75 161 9" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 161 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.5" />
                            <Vertex pos="0.25 3 -0.5" />
                            <Vertex pos="0.25 -3 0.5" />
                            <Vertex pos="0.25 -3 -0.5" />
                            <Vertex pos="-0.25 3 0.5" />
                            <Vertex pos="-0.25 3 -0.5" />
                            <Vertex pos="-0.25 -3 0.5" />
                            <Vertex pos="-0.25 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="269" owner="0" type="0" pos="-18.25 156 11" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 156 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="270" owner="0" type="0" pos="-18.75 156 11" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 156 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="271" owner="0" type="0" pos="-18.25 166 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 166 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="272" owner="0" type="0" pos="-18.75 166 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 166 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="273" owner="0" type="0" pos="-18.25 170 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 170 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -9.53674e-007" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 -9.53674e-007" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.499999" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.499999" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="274" owner="0" type="0" pos="-18.75 170 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 170 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="275" owner="0" type="0" pos="-18.25 178.25 13" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 178.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.75 0" />
                            <Vertex pos="0.25 5.75 -0.499999" />
                            <Vertex pos="0.25 -6.25 0" />
                            <Vertex pos="0.25 -6.25 -0.5" />
                            <Vertex pos="-0.25 6.25 0.5" />
                            <Vertex pos="-0.25 6.25 -0.499999" />
                            <Vertex pos="-0.25 -6.25 0.5" />
                            <Vertex pos="-0.25 -6.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3648 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3520 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.24264" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 8.44399e-008 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="276" owner="0" type="0" pos="-18.75 178.5 13" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 178.5 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.5" />
                            <Vertex pos="0.25 6 -0.499999" />
                            <Vertex pos="0.25 -6.5 0.5" />
                            <Vertex pos="0.25 -6.5 -0.5" />
                            <Vertex pos="-0.25 6.5 0.5" />
                            <Vertex pos="-0.25 6.5 -0.499999" />
                            <Vertex pos="-0.25 -6.5 0.5" />
                            <Vertex pos="-0.25 -6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.41942" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 8.10623e-008 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="277" owner="0" type="0" pos="-9.25 178.5 13" rot="1 0 0 0" scale="" transform="1 0 0 -9.25 0 1 0 178.5 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.50002 0.5" />
                            <Vertex pos="0.25 6.50002 -0.499999" />
                            <Vertex pos="0.25 -6.50002 0.5" />
                            <Vertex pos="0.25 -6.50002 -0.5" />
                            <Vertex pos="-0.25 6.00002 0.5" />
                            <Vertex pos="-0.25 6.00002 -0.499999" />
                            <Vertex pos="-0.25 -6.50002 0.5" />
                            <Vertex pos="-0.25 -6.50002 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4736 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4608 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -4.41943" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.50002" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 7.79443e-008 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="278" owner="0" type="0" pos="-9.75 178.25 13" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 178.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.24997 0.500001" />
                            <Vertex pos="0.25 6.24998 -0.500001" />
                            <Vertex pos="0.25 -6.25 0.5" />
                            <Vertex pos="0.25 -6.25 -0.500002" />
                            <Vertex pos="-0.25 5.74997 9.53674e-007" />
                            <Vertex pos="-0.25 5.74998 -0.500001" />
                            <Vertex pos="-0.25 -6.25 0" />
                            <Vertex pos="-0.25 -6.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4672 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4544 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 7.08066e-006 -4.24262" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 -5.61959e-008 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 8.10624e-008 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="279" owner="0" type="0" pos="-14 184.25 13" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 184.25 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.50005 0.25 0.500016" />
                            <Vertex pos="4.50004 0.25 -0.500015" />
                            <Vertex pos="4.00003 -0.250015 6.38962e-005" />
                            <Vertex pos="4.00004 -0.25 -0.500015" />
                            <Vertex pos="-4.50005 0.25 0.500016" />
                            <Vertex pos="-4.50004 0.25 -0.500015" />
                            <Vertex pos="-4.00003 -0.250015 6.38962e-005" />
                            <Vertex pos="-4.00004 -0.25 -0.500015" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 -7.03741e-006 -3.00524" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0.0100098 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 -7.08045e-006 -3.00524" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0.0100098 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 0.0100098 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -2.99764e-005 -0.250015" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 0.0100098 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707062 0.707151 -0.176821" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500015" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="280" owner="0" type="0" pos="-14 184.75 13" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 184.75 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.00002 0.25 0.5" />
                            <Vertex pos="5.00002 0.25 -0.5" />
                            <Vertex pos="4.50002 -0.25 0.5" />
                            <Vertex pos="4.50002 -0.25 -0.5" />
                            <Vertex pos="-5.00002 0.25 0.5" />
                            <Vertex pos="-5.00002 0.25 -0.5" />
                            <Vertex pos="-4.50002 -0.25 0.5" />
                            <Vertex pos="-4.50002 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -3.35877" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.35877" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="281" owner="0" type="0" pos="2 9 1.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 9 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 2304 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -2304 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_trim" texgens="1 0 0 512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="282" owner="0" type="0" pos="2 15 1.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 15 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 3840 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -3840 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_trim" texgens="1 0 0 512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="283" owner="0" type="0" pos="2 18 1.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 18 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 4608 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -4608 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="284" owner="0" type="0" pos="2 12 2.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 12 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 3072 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -3072 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 512 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="285" owner="0" type="0" pos="24 42 0.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 42 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 10752 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -10752 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -6144 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 6144 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="286" owner="0" type="0" pos="24 46 1.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 46 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 11776 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -11776 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -6144 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 6144 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="287" owner="0" type="0" pos="22 50 1.75" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 50 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 12800 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -12800 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -5632 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 5632 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="288" owner="0" type="0" pos="20 54 1.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 54 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 13824 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -13824 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -5120 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 5120 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="289" owner="0" type="0" pos="24 58 2.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 58 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 14848 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -14848 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -6144 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 6144 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="290" owner="0" type="0" pos="28 60 3.25" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 60 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 15360 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -15360 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 -7168 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 7168 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="291" owner="0" type="0" pos="25 62 3.75" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 62 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 15872 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -15872 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -6400 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 6400 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="292" owner="0" type="0" pos="26 66 4.25" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 66 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 16896 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -16896 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -6656 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 6656 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="293" owner="0" type="0" pos="23 64 4.75" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 64 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 16384 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -16384 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 -5888 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 5888 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_physics_repulsion" texgens="1 0 0 5888 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="294" owner="0" type="0" pos="0 66 11.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 66 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 16896 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -16896 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 0 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="295" owner="0" type="0" pos="0 62 11.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 62 0 0 1 11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 15872 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -15872 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 0 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="296" owner="0" type="0" pos="-4 66 12.25" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 66 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 16896 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -16896 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 1024 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -1024 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="297" owner="0" type="0" pos="-6 62 12.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 62 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 15872 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -15872 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 1536 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -1536 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="298" owner="0" type="0" pos="-11 65 12.75" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 65 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-1 3 0.25" />
                            <Vertex pos="-1 3 -0.25" />
                            <Vertex pos="-1 -3 0.25" />
                            <Vertex pos="-1 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 16640 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 768 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="299" owner="0" type="0" pos="-30 122 5.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 122 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 31232 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -31232 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 7680 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -7680 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="300" owner="0" type="0" pos="-36 116 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 116 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 29696 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -29696 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 9216 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 -9216 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="301" owner="0" type="0" pos="-36 110 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 110 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 28160 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -28160 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 9216 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -9216 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="302" owner="0" type="0" pos="-32 110 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 110 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 28160 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -28160 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 8192 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -8192 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="303" owner="0" type="0" pos="-34 106 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 106 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 27136 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -27136 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="304" owner="0" type="0" pos="-34 102 -9" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 102 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 18" />
                            <Vertex pos="4 2 -18" />
                            <Vertex pos="4 -2 18" />
                            <Vertex pos="4 -2 -18" />
                            <Vertex pos="-4 2 18" />
                            <Vertex pos="-4 2 -18" />
                            <Vertex pos="-4 -2 18" />
                            <Vertex pos="-4 -2 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="305" owner="0" type="0" pos="-32 118 4.75" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 118 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 30208 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -30208 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 8192 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -8192 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="306" owner="0" type="0" pos="-20 64 12.75" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 64 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 16384 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -16384 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 5120 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 -5120 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="307" owner="0" type="0" pos="-24 66 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 66 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 16896 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -16896 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 6144 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -6144 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="308" owner="0" type="0" pos="-26 62 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 62 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 15872 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -15872 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 6656 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -6656 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="309" owner="0" type="0" pos="-30 66 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 66 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 16896 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -16896 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 7680 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -7680 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="310" owner="0" type="0" pos="-36 68 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 68 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 17408 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -17408 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 9216 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 -9216 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="311" owner="0" type="0" pos="-32 72 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 72 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 18432 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -18432 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 8192 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 -8192 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="312" owner="0" type="0" pos="21 64 -10.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 64 0 0 1 -10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 16.75" />
                            <Vertex pos="1 4 -16.75" />
                            <Vertex pos="1 -4 16.75" />
                            <Vertex pos="1 -4 -16.75" />
                            <Vertex pos="-1 4 16.75" />
                            <Vertex pos="-1 4 -16.75" />
                            <Vertex pos="-1 -4 16.75" />
                            <Vertex pos="-1 -4 -16.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.75" album="" material="bm_tile03_A" texgens="1 0 0 768 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="313" owner="0" type="0" pos="21 64 6.75" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 64 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 16384 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -16384 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 -5376 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 5376 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="314" owner="0" type="0" pos="26.5 40.5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 26.5 0 1 0 40.5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="315" owner="0" type="0" pos="26.5 44.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 26.5 0 1 0 44.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="316" owner="0" type="0" pos="17.5 48.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 17.5 0 1 0 48.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="317" owner="0" type="0" pos="17.5 55.5 1" rot="1 0 0 0" scale="" transform="1 0 0 17.5 0 1 0 55.5 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="318" owner="0" type="0" pos="26.5 55.5 2.5" rot="1 0 0 0" scale="" transform="1 0 0 26.5 0 1 0 55.5 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="319" owner="0" type="0" pos="28.5 64.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 28.5 0 1 0 64.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="320" owner="0" type="0" pos="21.5 68.5 5.5" rot="1 0 0 0" scale="" transform="1 0 0 21.5 0 1 0 68.5 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="321" owner="0" type="0" pos="1.5 68.5 11" rot="1 0 0 0" scale="" transform="1 0 0 1.5 0 1 0 68.5 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="322" owner="0" type="0" pos="-10.5 68.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 68.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="323" owner="0" type="0" pos="-2.5 59.5 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 59.5 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.75" />
                            <Vertex pos="0.5 0.5 -0.75" />
                            <Vertex pos="0.5 -0.5 0.75" />
                            <Vertex pos="0.5 -0.5 -0.75" />
                            <Vertex pos="-0.5 0.5 0.75" />
                            <Vertex pos="-0.5 0.5 -0.75" />
                            <Vertex pos="-0.5 -0.5 0.75" />
                            <Vertex pos="-0.5 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.75" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="324" owner="0" type="0" pos="-21.5 59.5 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 59.5 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="325" owner="0" type="0" pos="-21.5 68.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 68.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="326" owner="0" type="0" pos="-25.5 68.5 10.5" rot="1 0 0 0" scale="" transform="1 0 0 -25.5 0 1 0 68.5 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="327" owner="0" type="0" pos="-29.5 68.5 8.5" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 68.5 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="328" owner="0" type="0" pos="-33.5 63.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 63.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="329" owner="0" type="0" pos="-30.5 63.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 63.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="330" owner="0" type="0" pos="-38.5 71.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 71.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 2" />
                            <Vertex pos="0.5 0.5 -2" />
                            <Vertex pos="0.5 -0.5 2" />
                            <Vertex pos="0.5 -0.5 -2" />
                            <Vertex pos="-0.5 0.5 2" />
                            <Vertex pos="-0.5 0.5 -2" />
                            <Vertex pos="-0.5 -0.5 2" />
                            <Vertex pos="-0.5 -0.5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="331" owner="0" type="0" pos="-29.5 75.5 6" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 75.5 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1.5" />
                            <Vertex pos="0.5 0.5 -1.5" />
                            <Vertex pos="0.5 -0.5 1.5" />
                            <Vertex pos="0.5 -0.5 -1.5" />
                            <Vertex pos="-0.5 0.5 1.5" />
                            <Vertex pos="-0.5 0.5 -1.5" />
                            <Vertex pos="-0.5 -0.5 1.5" />
                            <Vertex pos="-0.5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="332" owner="0" type="0" pos="-38.5 100.5 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 100.5 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -3" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -3" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -3" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="333" owner="0" type="0" pos="-29.5 100.5 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 100.5 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -3" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -3" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -3" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="334" owner="0" type="0" pos="-29.5 107.5 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 107.5 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="335" owner="0" type="0" pos="-38.5 107.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 107.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="336" owner="0" type="0" pos="-38.5 111.5 6.25" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 111.5 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1.25" />
                            <Vertex pos="0.5 0.5 -1.25" />
                            <Vertex pos="0.5 -0.5 1.25" />
                            <Vertex pos="0.5 -0.5 -1.25" />
                            <Vertex pos="-0.5 0.5 1.25" />
                            <Vertex pos="-0.5 0.5 -1.25" />
                            <Vertex pos="-0.5 -0.5 1.25" />
                            <Vertex pos="-0.5 -0.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="337" owner="0" type="0" pos="-29.5 111.5 4.5" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 111.5 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 2" />
                            <Vertex pos="0.5 0.5 -2" />
                            <Vertex pos="0.5 -0.5 2" />
                            <Vertex pos="0.5 -0.5 -2" />
                            <Vertex pos="-0.5 0.5 2" />
                            <Vertex pos="-0.5 0.5 -2" />
                            <Vertex pos="-0.5 -0.5 2" />
                            <Vertex pos="-0.5 -0.5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="338" owner="0" type="0" pos="-29.5 115.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 115.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1.25" />
                            <Vertex pos="0.5 0.5 -1.25" />
                            <Vertex pos="0.5 -0.5 1.25" />
                            <Vertex pos="0.5 -0.5 -1.25" />
                            <Vertex pos="-0.5 0.5 1.25" />
                            <Vertex pos="-0.5 0.5 -1.25" />
                            <Vertex pos="-0.5 -0.5 1.25" />
                            <Vertex pos="-0.5 -0.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="339" owner="0" type="0" pos="-25.5 123.5 6" rot="1 0 0 0" scale="" transform="1 0 0 -25.5 0 1 0 123.5 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="340" owner="0" type="0" pos="-17.5 127.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -17.5 0 1 0 127.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -3" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -3" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -3" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="341" owner="0" type="0" pos="-18.5 136.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 136.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -3" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -3" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -3" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="342" owner="0" type="0" pos="-14 138 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 138 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 19.75" />
                            <Vertex pos="4 2 -19.75" />
                            <Vertex pos="4 -2 19.75" />
                            <Vertex pos="4 -2 -19.75" />
                            <Vertex pos="-4 2 19.75" />
                            <Vertex pos="-4 2 -19.75" />
                            <Vertex pos="-4 -2 19.75" />
                            <Vertex pos="-4 -2 -19.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19.75" album="" material="bm_tile03_A" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="343" owner="0" type="0" pos="-14 138 12.75" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 138 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 35328 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -35328 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 3584 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -3584 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="344" owner="0" type="0" pos="-16 142 12.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 142 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 36352 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -36352 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 4096 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -4096 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="345" owner="0" type="0" pos="-16 146 11.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 146 0 0 1 11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 37376 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -37376 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 4096 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -4096 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="346" owner="0" type="0" pos="-16 156 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 156 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 39936 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -39936 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 4096 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -4096 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="347" owner="0" type="0" pos="-16 166 11.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 166 0 0 1 11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 42496 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -42496 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 4096 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -4096 0 0 -1 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="348" owner="0" type="0" pos="-16 170 12.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 170 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 43520 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -43520 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 4096 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -4096 0 0 -1 -3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="349" owner="0" type="0" pos="-14 178 12.75" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 178 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 0.25" />
                            <Vertex pos="4 6 -0.25" />
                            <Vertex pos="4 -6 0.25" />
                            <Vertex pos="4 -6 -0.25" />
                            <Vertex pos="-4 6 0.25" />
                            <Vertex pos="-4 6 -0.25" />
                            <Vertex pos="-4 -6 0.25" />
                            <Vertex pos="-4 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 45568 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -45568 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_trim" texgens="-1 0 0 3584 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_trim" texgens="1 0 0 -3584 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="350" owner="0" type="0" pos="-18.5 147.5 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 147.5 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1.25" />
                            <Vertex pos="0.5 0.5 -1.25" />
                            <Vertex pos="0.5 -0.5 1.25" />
                            <Vertex pos="0.5 -0.5 -1.25" />
                            <Vertex pos="-0.5 0.5 1.25" />
                            <Vertex pos="-0.5 0.5 -1.25" />
                            <Vertex pos="-0.5 -0.5 1.25" />
                            <Vertex pos="-0.5 -0.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="351" owner="0" type="0" pos="-18.5 164.5 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 164.5 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1.25" />
                            <Vertex pos="0.5 0.5 -1.25" />
                            <Vertex pos="0.5 -0.5 1.25" />
                            <Vertex pos="0.5 -0.5 -1.25" />
                            <Vertex pos="-0.5 0.5 1.25" />
                            <Vertex pos="-0.5 0.5 -1.25" />
                            <Vertex pos="-0.5 -0.5 1.25" />
                            <Vertex pos="-0.5 -0.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="352" owner="0" type="0" pos="-18.5 157.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 157.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="353" owner="0" type="0" pos="-18.5 154.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 154.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="354" owner="0" type="0" pos="-18.5 143.5 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 143.5 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="355" owner="0" type="0" pos="-18.5 168.5 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 168.5 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="356" owner="0" type="0" pos="6.125 64 10.75" rot="1 0 0 0" scale="" transform="1 0 0 6.125 0 1 0 64 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 16384 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -16384 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_trim" texgens="-1 0 0 -1568 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_trim" texgens="1 0 0 1568 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 1568 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -1568 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="357" owner="0" type="0" pos="-34 84.125 4.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 84.125 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.125 0.25" />
                            <Vertex pos="4.5 0.125 -0.25" />
                            <Vertex pos="4.5 -0.125 0.25" />
                            <Vertex pos="4.5 -0.125 -0.25" />
                            <Vertex pos="-4.5 0.125 0.25" />
                            <Vertex pos="-4.5 0.125 -0.25" />
                            <Vertex pos="-4.5 -0.125 0.25" />
                            <Vertex pos="-4.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_trim" texgens="0 1 0 21536 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_trim" texgens="0 -1 0 -21536 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 8704 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -8704 0 0 -1 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -8704 0 -1 0 -21536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 8704 0 -1 0 -21536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="358" owner="0" type="0" pos="-34 91.875 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 91.875 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.125 0.25" />
                            <Vertex pos="4.5 0.125 -0.25" />
                            <Vertex pos="4.5 -0.125 0.25" />
                            <Vertex pos="4.5 -0.125 -0.25" />
                            <Vertex pos="-4.5 0.125 0.25" />
                            <Vertex pos="-4.5 0.125 -0.25" />
                            <Vertex pos="-4.5 -0.125 0.25" />
                            <Vertex pos="-4.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_trim" texgens="0 1 0 23520 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_trim" texgens="0 -1 0 -23520 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 8704 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -8704 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -8704 0 -1 0 -23520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 8704 0 -1 0 -23520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="359" owner="0" type="0" pos="-42 66 -15" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 66 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 12" />
                            <Vertex pos="4 2 -12" />
                            <Vertex pos="4 -2 12" />
                            <Vertex pos="4 -2 -12" />
                            <Vertex pos="-4 2 12" />
                            <Vertex pos="-4 2 -12" />
                            <Vertex pos="-4 -2 12" />
                            <Vertex pos="-4 -2 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="360" owner="0" type="0" pos="-46.25 66 -3" rot="1 0 0 0" scale="" transform="1 0 0 -46.25 0 1 0 66 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -3.09944e-006" />
                            <Vertex pos="0.25 2 -0.499997" />
                            <Vertex pos="0.25 -2 -3.09944e-006" />
                            <Vertex pos="0.25 -2 -0.499997" />
                            <Vertex pos="-0.25 2 0.499997" />
                            <Vertex pos="-0.25 2 -0.499997" />
                            <Vertex pos="-0.25 -2 0.499997" />
                            <Vertex pos="-0.25 -2 -0.499997" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176775" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499997" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="361" owner="0" type="0" pos="-46.75 66 -3" rot="1 0 0 0" scale="" transform="1 0 0 -46.75 0 1 0 66 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="362" owner="0" type="0" pos="-42 86 -15" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 86 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 12" />
                            <Vertex pos="4 6 -12" />
                            <Vertex pos="4 -6 12" />
                            <Vertex pos="4 -6 -12" />
                            <Vertex pos="-4 6 12" />
                            <Vertex pos="-4 6 -12" />
                            <Vertex pos="-4 -6 12" />
                            <Vertex pos="-4 -6 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="363" owner="0" type="0" pos="-46.25 86.25 -3" rot="1 0 0 0" scale="" transform="1 0 0 -46.25 0 1 0 86.25 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.74999 -4.76837e-007" />
                            <Vertex pos="0.25 5.74999 -0.500003" />
                            <Vertex pos="0.25 -6.25 -7.15256e-007" />
                            <Vertex pos="0.25 -6.25 -0.500002" />
                            <Vertex pos="-0.25 6.24999 0.500003" />
                            <Vertex pos="-0.25 6.24999 -0.500003" />
                            <Vertex pos="-0.25 -6.25 0.500002" />
                            <Vertex pos="-0.25 -6.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.24263" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707109 -5.39478e-008 0.707104 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -7.94729e-008 -1 -0.500003" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="364" owner="0" type="0" pos="-46.75 86.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -46.75 0 1 0 86.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.5" />
                            <Vertex pos="0.25 6 -0.5" />
                            <Vertex pos="0.25 -6.5 0.5" />
                            <Vertex pos="0.25 -6.5 -0.5" />
                            <Vertex pos="-0.25 6.5 0.5" />
                            <Vertex pos="-0.25 6.5 -0.5" />
                            <Vertex pos="-0.25 -6.5 0.5" />
                            <Vertex pos="-0.25 -6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.41942" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="365" owner="0" type="0" pos="-42 74 -15" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 74 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 12" />
                            <Vertex pos="4 6 -12" />
                            <Vertex pos="4 -6 12" />
                            <Vertex pos="4 -6 -12" />
                            <Vertex pos="-4 6 12" />
                            <Vertex pos="-4 6 -12" />
                            <Vertex pos="-4 -6 12" />
                            <Vertex pos="-4 -6 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="366" owner="0" type="0" pos="-46.125 74 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -46.125 0 1 0 74 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 6 0.25" />
                            <Vertex pos="0.125 6 -0.25" />
                            <Vertex pos="0.125 -6 0.25" />
                            <Vertex pos="0.125 -6 -0.25" />
                            <Vertex pos="-0.125 6 0.25" />
                            <Vertex pos="-0.125 6 -0.25" />
                            <Vertex pos="-0.125 -6 0.25" />
                            <Vertex pos="-0.125 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 18944 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -18944 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_trim" texgens="-1 0 0 11808 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_trim" texgens="1 0 0 -11808 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -11808 0 -1 0 -18944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 11808 0 -1 0 -18944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="367" owner="0" type="0" pos="-46.25 92.25 -3" rot="1 0 0 0" scale="" transform="1 0 0 -46.25 0 1 0 92.25 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.25 0.500004" />
                            <Vertex pos="4.25 0.25 -0.500004" />
                            <Vertex pos="4.25 -0.250008 3.57628e-006" />
                            <Vertex pos="4.25 -0.25 -0.500004" />
                            <Vertex pos="-0.25 0.25 0.500004" />
                            <Vertex pos="-0.25 0.25 -0.500004" />
                            <Vertex pos="0.25 -0.250008 3.57628e-006" />
                            <Vertex pos="0.25 -0.25 -0.500004" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2112 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-8.9407e-008 -1 -1.52586e-005 -0.250008" album="" material="bm_edge_white" texgens="1 0 0 -1984 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="9.36603e-009 -0.707102 0.707112 -0.176783" album="" material="bm_edge_white" texgens="1 0 0 -1984 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="1.49012e-008 0 -1 -0.500004" album="" material="bm_edge_white" texgens="-1 0 0 2112 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="368" owner="0" type="0" pos="-46.5 92.75 -3" rot="1 0 0 0" scale="" transform="1 0 0 -46.5 0 1 0 92.75 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-0.5 0.25 0.5" />
                            <Vertex pos="-0.5 0.25 -0.5" />
                            <Vertex pos="0 -0.25 0.5" />
                            <Vertex pos="0 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2176 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="369" owner="0" type="0" pos="-42 90 -15" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 90 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 10" />
                            <Vertex pos="4 6 -12" />
                            <Vertex pos="4 2 10" />
                            <Vertex pos="4 2 -12" />
                            <Vertex pos="0 6 10" />
                            <Vertex pos="0 6 -12" />
                            <Vertex pos="0 2 10" />
                            <Vertex pos="0 2 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_tile03_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="370" owner="0" type="0" pos="-42.25 90.25 -5" rot="1 0 0 0" scale="" transform="1 0 0 -42.25 0 1 0 90.25 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.74999 -4.76837e-007" />
                            <Vertex pos="0.25 5.74999 -0.500003" />
                            <Vertex pos="0.25 1.75 -9.53674e-007" />
                            <Vertex pos="0.25 1.75 -0.500002" />
                            <Vertex pos="-0.25 6.24999 0.500003" />
                            <Vertex pos="-0.25 6.24999 -0.500003" />
                            <Vertex pos="-0.25 1.75 0.500002" />
                            <Vertex pos="-0.25 1.75 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.24263" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1.75" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707109 -1.68587e-007 0.707104 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -2.68222e-007 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="371" owner="0" type="0" pos="-42.75 90.5 -5" rot="1 0 0 0" scale="" transform="1 0 0 -42.75 0 1 0 90.5 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.5" />
                            <Vertex pos="0.25 6 -0.5" />
                            <Vertex pos="0.25 1.5 0.5" />
                            <Vertex pos="0.25 1.5 -0.5" />
                            <Vertex pos="-0.25 6.5 0.5" />
                            <Vertex pos="-0.25 6.5 -0.5" />
                            <Vertex pos="-0.25 1.5 0.5" />
                            <Vertex pos="-0.25 1.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.41942" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2112 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2240 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="372" owner="0" type="0" pos="-38.25 96.25 -5" rot="1 0 0 0" scale="" transform="1 0 0 -38.25 0 1 0 96.25 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.500004" />
                            <Vertex pos="0.25 0.25 -0.500004" />
                            <Vertex pos="0.25 -0.250008 3.8147e-006" />
                            <Vertex pos="0.25 -0.25 -0.500004" />
                            <Vertex pos="-4.25 0.25 0.500004" />
                            <Vertex pos="-4.25 0.25 -0.500004" />
                            <Vertex pos="-3.75 -0.250008 3.57628e-006" />
                            <Vertex pos="-3.75 -0.25 -0.500004" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2112 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="8.94079e-008 -1 -1.59738e-005 -0.250008" album="" material="bm_edge_white" texgens="1 0 0 -1984 0 0 -1 0.00201416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="2.80981e-008 -0.707101 0.707112 -0.176783" album="" material="bm_edge_white" texgens="1 0 0 -1984 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="4.47035e-008 0 -1 -0.500004" album="" material="bm_edge_white" texgens="-1 0 0 2112 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="373" owner="0" type="0" pos="-38.5 96.75 -5" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 96.75 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.5" />
                            <Vertex pos="0.5 0.25 -0.5" />
                            <Vertex pos="0.5 -0.25 0.5" />
                            <Vertex pos="0.5 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2176 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="374" owner="0" type="0" pos="-42.5 92.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -42.5 0 1 0 92.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 0.5 -2" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 -2" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 -2" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.5" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
